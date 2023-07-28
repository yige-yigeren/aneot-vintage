﻿namespace AnEoT.Vintage.Helpers;

/// <summary>
/// 帮助获取页面标题的类
/// </summary>
public static class PageTitleHelper
{
    /// <summary>
    /// 通过页面 Uri 获取指定页面的标题
    /// </summary>
    /// <param name="webRootPath">"wwwroot"文件夹的路径</param>
    /// <param name="uriPath">Uri 路径</param>
    /// <returns>目标页面的标题</returns>
    public static string GetPageTitle(string webRootPath, string uriPath)
    {
        FileInfo fileInfo = new(Path.Combine(webRootPath, uriPath, "README.md"));

        if (!fileInfo.Exists)
        {
            throw new FileNotFoundException($"找不到指定的文件：{fileInfo.FullName}");
        }

        string markdown = File.ReadAllText(fileInfo.FullName);

        ArticleInfo info = MarkdownHelper.GetFromFrontMatter<ArticleInfo>(markdown);

        return info.Title;
    }
}
