﻿using System;
using System.Web.UI.WebControls;

using PetShop.Business;

namespace PetShop.UI.Controls
{
    public partial class WishListControl : System.Web.UI.UserControl
    {
        /// <summary>
        /// Handle Page load event
        /// </summary>
        protected void Page_PreRender(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindCart();
            }
        }

        /// <summary>
        /// Bind repeater to Cart object in Profile
        /// </summary>
        private void BindCart()
        {
            Profile profile = ProfileManager.Instance.GetCurrentUser(Page.User.Identity.Name);

            Business.CartList wishList = profile.WishList;
            if (wishList.Count > 0)
            {
                repWishList.DataSource = wishList;
                repWishList.DataBind();
            }
            else
            {
                repWishList.Visible = false;
                lblMsg.Text = "Your wish list is empty.";
            }
        }

        /// <summary>
        /// Handler for Delete/Move buttons
        /// </summary>
        protected void CartItem_Command(object sender, CommandEventArgs e)
        {
            Profile profile = ProfileManager.Instance.GetCurrentUser(Page.User.Identity.Name);

            switch (e.CommandName)
            {
                case "Del":
                    profile.WishList.Remove(e.CommandArgument.ToString());
                    break;
                case "Move":
                    profile.WishList.Remove(e.CommandArgument.ToString());
                    profile.ShoppingCart.Add(e.CommandArgument.ToString(), profile.UniqueID, true);
                    break;
            }

            profile = profile.Save();

            BindCart();
        }
    }
}
