## **RU**

1. Импортируйте dll в ваш проект 
2. Создайте файл LoggerSettings.json в корне проекта
2.1 Пример json файла есть в архиве/репозитории
3. using Logger
4. Log log = new Log();


log.Info("Info log");
log.Debug("Debug log");
log.Eror("Error log");

## **EN**

1. Import dll into your project
2. Create LoggerSettings.json file in the project root
2.1 An example of json file is in the archive/repository
3. using Logger
4. Log log = new Log();

log.Info("Info log");
log.Debug("Debug log");
log.Eror("Error log");

## **Example / Пример**

**The main project / Основной проект**

```C#
using System; 
using Logger; 
 
namespace Primer; 
 
public class Program 
{
    Log log = new Log(); 
    public static void Main()
    {

        Log.Start(); //Initialize Logger

        int a = 1;
        string b = "Frizz@LastFire";

        log.Debug(a); // [time] 1

        try
        {
            log.Debug(b); // [time] Frizz@LastFire
        }
        catch (Exception ex)
        {
            log.Eror(ex);
        }




    } 
}
```

JSON FILE 

```Json
{
  "PathToFolder": {
    "PathString": "/home/frizz/Документы/logs/Log"
  }
}
```