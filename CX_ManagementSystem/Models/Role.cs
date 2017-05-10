using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CX_ManagementSystem.Models
{
    public class Role
    {
        [Key]
        public int RoleID { get; set; }

        /// <summary>
        /// 角色名称
        /// </summary>
        [Required(ErrorMessage = "必填")]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "{1}到{0}个字")]
        [Display(Name = "角色名称")]
        public string RoleName { get; set; }
        
        /// <summary>
        /// 角色父级ID
        /// </summary>
        [Required(ErrorMessage ="必填")]
        public int ParentID { get; set; }

        /// <summary>
        /// 说明
        /// </summary>
        [Display(Name = "角色名称")]
        public string Description { get; set; }
    }
}