﻿using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;

namespace UploadModel.Pages
{
    public class IndexModel : UploadModelPageModel
    {
        public void OnGet()
        {
            
        }

        public async Task OnPostLoginAsync()
        {
            await HttpContext.ChallengeAsync("oidc");
        }
    }
}