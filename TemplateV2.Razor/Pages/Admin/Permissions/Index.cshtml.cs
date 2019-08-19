using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Threading.Tasks;
using TemplateV2.Models.DomainModels;
using TemplateV2.Services.Contracts;

namespace TemplateV2.Razor.Pages
{
    public class ManagePermissionsModel : PageModel
    {
        #region Private Fields

        private readonly IAdminService _adminService;

        #endregion

        #region Properties

        public List<PermissionEntity> Permissions { get; set; }

        #endregion

        #region Constructors

        public ManagePermissionsModel(IAdminService adminService)
        {
            _adminService = adminService;

            Permissions = new List<PermissionEntity>();
        }

        #endregion

        public async Task OnGet()
        {
            var response = await _adminService.GetPermissions();
            Permissions = response.Permissions;
        }
    }
}
