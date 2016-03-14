using System;
using System.Linq;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraEditors;
using Framework.Interfaces.App;
using Framework.Interfaces.Helper;
using Microsoft.Practices.Unity;
using Resource;

namespace Framework.Base.App
{
    public sealed class KZTileNavPane : TileNavPane
    {
        private NavButton _navButtonHome;

        private NavButton _navButtonMenu;

        public KZTileNavPane(IUnityContainer container, Form view)
        {
            KZHelper = container.Resolve<IKZHelper>();
            View = view;
            DefaultCategory.AllowGlyphSkinning = DefaultBoolean.True;
            InitNavPain();
        }

        private IKZHelper KZHelper { get; }

        public Form View { get; set; }


        public KZBindingList<IApp> ListApps
        {
            set
            {
                if (value != null && value.Count > 0)
                {
                    foreach (var app in value)
                    {
                        AddAppItem(app);
                    }
                }
            }
        }

        public Action HomeClick { get; set; }


        public Action<IApp> ItemClick { get; set; }

        private void TileItem2_ItemClick(object sender, TileItemEventArgs e)
        {
            var tileItem = sender as TileItem;
            if (tileItem != null)
            {
                var app = tileItem.Tag as IApp;
                ItemClick?.Invoke(app);
            }
        }

        private void AddAppItem(IApp app)
        {
            var tileNavItem1 = new TileNavCategory();


            KZHelper.KZAppearanceSetter.SetAppearance(tileNavItem1.Tile.Appearance, KZHelper.KZFonts.ContentBoldFont,
                KZHelper.KZColours.TileColour.ActiveColour,
                KZHelper.KZColours.TileForeColour.ActiveColour);

            KZHelper.KZAppearanceSetter.SetAppearance(tileNavItem1.Tile.AppearanceHover, KZHelper.KZFonts.ContentBoldFont,
                KZHelper.KZColours.TileColour.HoverColour,
                KZHelper.KZColours.TileForeColour.HoverColour);

            KZHelper.KZAppearanceSetter.SetAppearance(tileNavItem1.Tile.AppearanceSelected, KZHelper.KZFonts.ContentBoldFont,
                KZHelper.KZColours.TileColour.SelectColour, KZHelper.KZColours.TileForeColour.SelectColour);


            KZHelper.KZAppearanceSetter.SetAppearance(tileNavItem1.Tile.AppearanceItem.Normal,
                KZHelper.KZFonts.ContentBoldFont, KZHelper.KZColours.TileColour.ActiveColour,
                KZHelper.KZColours.TileForeColour.ActiveColour);

            KZHelper.KZAppearanceSetter.SetAppearance(tileNavItem1.Tile.AppearanceItem.Hovered,
                KZHelper.KZFonts.ContentBoldFont, KZHelper.KZColours.TileColour.HoverColour,
                KZHelper.KZColours.TileForeColour.HoverColour);

            KZHelper.KZAppearanceSetter.SetAppearance(tileNavItem1.Tile.AppearanceItem.Pressed,
                KZHelper.KZFonts.ContentBoldFont,
                KZHelper.KZColours.TileColour.SelectColour, KZHelper.KZColours.TileForeColour.SelectColour);

            KZHelper.KZAppearanceSetter.SetAppearance(tileNavItem1.Tile.AppearanceItem.Selected,
                KZHelper.KZFonts.ContentBoldFont,
                KZHelper.KZColours.TileColour.SelectColour, KZHelper.KZColours.TileForeColour.SelectColour);


            tileNavItem1.AllowGlyphSkinning = DefaultBoolean.True;
            tileNavItem1.Tile.AllowGlyphSkinning = DefaultBoolean.True;
            tileNavItem1.Tile.ItemSize = TileBarItemSize.Wide;
            tileNavItem1.Tile.Id = app.Id;
            tileNavItem1.Tile.Tag = app;
            tileNavItem1.Caption = app.Name;

            tileNavItem1.Tag = app;

            tileNavItem1.Tile.ItemClick += TileItem2_ItemClick;

            //var sub = new TileNavItem();
            //sub.Caption = app.Name;

            //KZHelper.KZAppearanceSetter.SetAppearance(sub.Tile.Appearance, KZHelper.KZFonts.ContentFont, KZHelper.KZColours.TileColour.ActiveColour,
            //   KZHelper.KZColours.TileForeColour.ActiveColour);

            //KZHelper.KZAppearanceSetter.SetAppearance(sub.Tile.AppearanceHover, KZHelper.KZFonts.ContentFont, KZHelper.KZColours.TileColour.HoverColour,
            //    KZHelper.KZColours.TileForeColour.HoverColour);

            //KZHelper.KZAppearanceSetter.SetAppearance(sub.Tile.AppearanceSelected, KZHelper.KZFonts.ContentFont,
            //    KZHelper.KZColours.TileColour.SelectColour, KZHelper.KZColours.TileForeColour.SelectColour);

            //tileNavItem1.Items.Add(sub);


            tileNavItem1.Tile.Elements.Add(new TileItemElement
            {
                Image = app.Image,
                ImageAlignment = TileItemContentAlignment.BottomRight,
                Text = app.Name
            });

            Categories.Add(tileNavItem1);
        }


        public void AdjustTitle(IApp application, bool isHome)
        {
            if (_navButtonMenu != null)
            {
                _navButtonMenu.Visible = !isHome;
            }
            if (_navButtonHome != null)
            {
                _navButtonHome.Visible = !isHome;
            }


            if (application == null) return;
            var selectedCategory = Categories.SingleOrDefault(s => s.Tag == application);
            if (selectedCategory != null)
            {
                SelectedElement = selectedCategory;
            }
        }

        public void InitNavPain()
        {
            #region _navButtonHome

            _navButtonHome = new NavButton();
            _navButtonHome.Alignment = NavButtonAlignment.Left;
            _navButtonHome.Glyph = Icons.Home_Black_32;
            _navButtonHome.ElementClick += NavButtonHome_ElementClick;

            #endregion

            #region _navButtonMenu

            _navButtonMenu = new NavButton();
            _navButtonMenu.Caption = translate.Application;
            _navButtonMenu.Visible = false;
            _navButtonMenu.IsMain = true;

            #endregion

            #region navButtonUser

            //var navButtonUser = new TileNavCategoryEx();
            //navButtonUser.Allignment = HorzAlignment.Far;
            //navButtonUser.Alignment = NavButtonAlignment.Right;
            //navButtonUser.Caption = "User";
            //navButtonUser.Glyph = Icons.User_Black_32;


            //var tileNavItem31 = new TileNavItem();
            //var tileNavItem32 = new TileNavItem();
            //var tileNavItem33 = new TileNavItem();


            //navButtonUser.Items.AddRange(new[]
            //{
            //    tileNavItem31,
            //    tileNavItem32,
            //    tileNavItem33
            //});

            #endregion

            #region navButtonMin

            var navButtonMin = new NavButton();
            navButtonMin.Alignment = NavButtonAlignment.Right;
            navButtonMin.Glyph = Icons.Minus_Black_32;
            navButtonMin.ElementClick += NavButtonMin_ElementClick;

            #endregion

            #region navButtonClose

            var navButtonClose = new NavButton();
            navButtonClose.Alignment = NavButtonAlignment.Right;
            navButtonClose.Glyph = Icons.Close_Black_32;
            navButtonClose.ElementClick += NavButtonClose_ElementClick;

            #endregion

            #region config

            AllowGlyphSkinning = true;
            ContinuousNavigation = false;
            Dock = DockStyle.Fill;
            ButtonPadding = new Padding(12);


            KZHelper.KZAppearanceSetter.SetAppearance(Appearance, KZHelper.KZFonts.ButtonFont,
                KZHelper.KZColours.MainColour.ActiveColour,
                KZHelper.KZColours.MainForeColour.ActiveColour);

            KZHelper.KZAppearanceSetter.SetAppearance(AppearanceHovered, KZHelper.KZFonts.ButtonFont,
                KZHelper.KZColours.MainColour.HoverColour,
                KZHelper.KZColours.MainForeColour.HoverColour);

            KZHelper.KZAppearanceSetter.SetAppearance(AppearanceSelected, KZHelper.KZFonts.ButtonFont,
                KZHelper.KZColours.MainColour.SelectColour, KZHelper.KZColours.MainForeColour.SelectColour);


            #endregion

                Buttons.Add(_navButtonHome);
            Buttons.Add(_navButtonMenu);
            //Buttons.Add(navButtonUser);
            Buttons.Add(navButtonMin);
            Buttons.Add(navButtonClose);
        }

        private void NavButtonHome_ElementClick(object sender, NavElementEventArgs e)
        {
            HomeClick?.Invoke();
        }

        #region Event

        private void NavButtonMin_ElementClick(object sender, NavElementEventArgs e)
        {
            View.WindowState = FormWindowState.Minimized;
        }

        private void NavButtonClose_ElementClick(object sender, NavElementEventArgs e)
        {
            View.Close();
        }

        #endregion
    }
}