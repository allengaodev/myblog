await Bootstrapper
    .Factory
    .CreateWeb(args)
    .DeployToGitHubPages(
        "myblog", //修改成自己的帳號
        "myblog.github.io", //修改成自己的帳號
        Config.FromSetting<string>("BLOG_TOKEN") //之後建立一個新的Github Token
    )
    .RunAsync();