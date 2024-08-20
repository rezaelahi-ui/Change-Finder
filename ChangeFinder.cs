
 public Result LogChanges(object current, object updated, int index)
 {
     Type type=current.GetType();
     if (type == updated.GetType())
     {
         try
         {
             var props = type.GetProperties();
             string ObjectName = type.GetCustomAttribute<DisplayAttribute>()?.Name ?? type.Name;
             var changes = props
                 .Where(p => Attribute.IsDefined(p, typeof(LogIfChangeAttribute)))
                 .Select(p => new ChangeLogModel
                 {
                     OldValue = p.GetValue(current)?.ToString(),
                     NewValue = p.GetValue(updated)?.ToString(),
                     PropertyName = p.GetCustomAttribute<DisplayAttribute>()?.Name ?? p.Name
                 })
                 .Where(change => change.OldValue != change.NewValue)
                 .ToList();

             if (changes.Any())
             {
                 var change = new ChangesLog
                 {
                     ChangeDate = new DateTools().GetPersianDate(DateTime.Now),
                     ChangedBy = loggedInUser.Informations.Id,
                     Changes = JsonConvert.SerializeObject(changes),
                     ObjectIndex = index,
                     ObjectName = ObjectName,
                     ChangeMode = Models.Types.ChangeMode.Change,
                 };
                 context.ChangesLogs.Add(change);
                 context.SaveChanges();
             }

             return new Result { Success = true };
         }
         catch (Exception ex)
         {
             // Optionally log the exception details for debugging
             // Logger.LogError(ex, "An error occurred while logging changes.");

             return new Result { Success = false };
         }
     }
     else
     {
         return new Result { Success = false };
     }
 }
