Официальный репозиторий Creeper ToolBox
----------
----------
----------
FAQ:
---
Вопрос: Как скомпилировать без Visual Studio или другой IDE?
Ответ: С помощью msbuild
1. Откройте командную строку
2. Откройте вашу директорию с .NET Framework
Обычно для 32 bit это C:\Windows\Microsoft.NET\Framework\v4.0.30319\
Обычно для 64 bit это C:\Windows\Microsoft.NET\Framework64\v4.0.30319\
3. В командной строке выполните команду (с кавычками) cd "ваш_путь_к_директории_net_framework"
4. В командной строке выполните команду (с кавычками) MSBuild /property:Configuration=Release "ваш_путь_к_файлу_launcher.csproj"
Вопрос: Я нашел баг, что мне делать
Ответ: Написать разработчику https://github.com/mrAppleXZ/CreeperToolBox/issues/new
