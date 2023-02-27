// код от Сергея с семинара 21.02.2023 (время +1час)
// Задача: вывести заголовок из html-страницы

using static MyMethods;

string url = "https://m.vk.com";
string localFile = "vkcom.html";
string beginSection = "<title>";
string endSection = "</title>";

string html = GetHtml(url, localFile);
string result = PartOfText(html, beginSection, endSection);
Console.WriteLine(result);

