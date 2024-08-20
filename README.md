
<!DOCTYPE html>
<html lang="en">
  <head>
    <meta charset="UTF-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title>Change Finder README</title>
    <style>
      body {
        font-family: Arial, sans-serif;
        line-height: 1.6;
        margin: 20px;
      }
      h1, h2 {
        color: #2c3e50;
      }
      code {
        background-color: #f4f4f4;
        padding: 2px 4px;
        border-radius: 3px;
      }
      pre {
        background-color: #f4f4f4;
        padding: 10px;
        border-radius: 5px;
        overflow-x: auto;
      }
      ul, ol {
        margin-bottom: 20px;
      }
    </style>
  </head>
  <body>
    <h1>Change Finder</h1>
    <p>
      This repository contains a .NET project that includes a Change Finder
      utility. The main purpose of this tool is to track and log changes in data
      over time. It provides a way to identify and document modifications
      efficiently.
    </p>
    <h2>Features</h2>
    <ul>
      <li>Detect changes in data models</li>
      <li>Log changes systematically</li>
      <li>Easy integration into existing .NET projects</li>
    </ul>
    <h2>Getting Started</h2>
    <p>To get started with the Change Finder utility:</p>
    <ol>
      <li>Clone the repository:</li>
      <pre><code>git clone https://github.com/yourusername/Change-Finder.git</code></pre>
      <li>Open the project in Visual Studio or any .NET-compatible IDE.</li>
      <li>
        Explore the <code>ChangeFinder.cs</code> and
        <code>ChangeLogModel.cs</code> files to understand the core
        functionality.
      </li>
    </ol>
    <h2>Usage</h2>
    <p>
      The main class <code>ChangeFinder.cs</code> is responsible for tracking
      changes, while <code>ChangeLogModel.cs</code> defines the structure of the
      logged changes. You can integrate these classes into your project and
      customize them according to your needs.
    </p>
    <h2>Contribution</h2>
    <p>
      Feel free to open issues or submit pull requests if you find any bugs or
      have suggestions for improvements.
    </p>
    <h2>License</h2>
    <p>
      This project is licensed under the MIT License - see the
      <a href="LICENSE">LICENSE</a> file for details.
    </p>
    <hr />
    <h1>Change Finder</h1>
    <p>
      این مخزن شامل یک پروژه‌ی .NET است که ابزار Change Finder را فراهم می‌کند.
      هدف اصلی این ابزار، ردیابی و ثبت تغییرات داده‌ها در طول زمان است. این
      ابزار به شما کمک می‌کند تغییرات را به‌صورت کارآمد شناسایی و مستند کنید.
    </p>
    <h2>ویژگی‌ها</h2>
    <ul>
      <li>شناسایی تغییرات در مدل‌های داده</li>
      <li>ثبت سیستماتیک تغییرات</li>
      <li>امکان یکپارچه‌سازی آسان با پروژه‌های موجود در .NET</li>
    </ul>
    <h2>شروع به کار</h2>
    <p>برای استفاده از ابزار Change Finder:</p>
    <ol>
      <li>مخزن را کلون کنید:</li>
      <pre><code>git clone https://github.com/yourusername/Change-Finder.git</code></pre>
      <li>
        برای استفاده از این ابزار شما باید <code>Attribute</code> 
        <strong>LogIfChange</strong> را در بالای فیلدها استفاده کنید.
      </li>
      <pre>
        <code>
public class ProductCategory
{{
    [Key]
    public int CategoryId {{ get; set; }}

    [Required(ErrorMessage = "وارد کردن نام گروه الزامیست")]
    [Display(Name = "نام گروه")]
    [ShowInReport]
    [LogIfChange]
    public string Name {{ get; set; }}
}}
        </code>
      </pre>
      <li>
        برای بهبود خوانایی گزارش‌ها، از <code>Attribute Display</code> استفاده کنید.
      </li>
    </ol>
    <h2>نحوه استفاده</h2>
    <p>
      کلاس اصلی <code>ChangeFinder.cs</code> مسئول ردیابی تغییرات است، در حالی
      که <code>ChangeLogModel.cs</code> ساختار تغییرات ثبت شده را تعریف می‌کند.
      می‌توانید این کلاس‌ها را به پروژه‌ی خود اضافه کرده و بر اساس نیازهای خود
      سفارشی‌سازی کنید.
    </p>
    <h2>مشارکت</h2>
    <p>
      اگر باگ یا پیشنهادی برای بهبود دارید، خوشحال می‌شویم که درخواست‌های pull
      یا issues باز کنید.
    </p>
    <h2>لایسنس</h2>
    <p>
      این پروژه تحت مجوز MIT قرار دارد - جزئیات بیشتر در فایل
      <a href="LICENSE">LICENSE</a> موجود است.
    </p>
  </body>
</html>
