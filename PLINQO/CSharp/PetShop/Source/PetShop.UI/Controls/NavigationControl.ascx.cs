﻿using System;
using System.Web.UI.WebControls;
using System.Linq;
using CodeSmith.Data.Linq;
using PetShop.Core.Data;

namespace PetShop.UI.Controls
{
    public partial class NavigationControl : System.Web.UI.UserControl
    {
        private string controlStyle;

        // control layout property
        protected string ControlStyle
        {
            get { return controlStyle; }
        }

        // Get properties based on control consumer
        protected void GetControlStyle()
        {
            controlStyle = Request.ServerVariables["SCRIPT_NAME"].ToLower().IndexOf("default.aspx") > 0 ? "navigationLinks" : "mainNavigation";
        }


        protected void Page_Load(object sender, EventArgs e)
        {
            GetControlStyle();
            BindCategories();

            // Select current category
            string categoryId = Request.QueryString["categoryId"];
            if (!string.IsNullOrEmpty(categoryId))
                SelectCategory(categoryId);
        }

        // Select current category.
        private void SelectCategory(string categoryId)
        {
            foreach (RepeaterItem item in rePCategories.Items)
            {
                var hidCategoryId = (HiddenField)item.FindControl("hidCategoryId");
                if (hidCategoryId.Value.ToLower() == categoryId.ToLower())
                {
                    var lnkCategory = (HyperLink)item.FindControl("lnkCategory");
                    lnkCategory.ForeColor = System.Drawing.Color.FromArgb(199, 116, 3);
                    break;
                }
            }
        }

        // Bind categories
        private void BindCategories()
        {
            using (var context = new PetShopDataContext())
            {
                rePCategories.DataSource = context.Category.OrderBy(c => c.Name).FromCache().ToList();
            }
            
            rePCategories.DataBind();
        }
    }
}