using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Web.Mvc;
using System.Web.Security;
using Trirand.Web.Mvc;
using System.Web.UI.WebControls;

namespace eTIMs.Models
{
    public class MasterModel
    {
    }

    public class DistrictMasterModel
    {
        public DistrictMasterModel()
        {
            JQGridColumn a = new JQGridColumn();
            DistrictMasterGrid = new JQGrid
            {
                Columns = new List<JQGridColumn>()
                                 {
                                     new JQGridColumn { DataField = "Id", 
                                                        HeaderText = "รหัสเขตการศึกษา",
                                                        // always set PrimaryKey for Add,Edit,Delete operations
                                                        // if not set, the first column will be assumed as primary key
                                                        PrimaryKey = true,
                                                        Editable = true,
                                                        Width = 100,
                                                        Searchable = true,
                                                        SearchType = SearchType.AutoComplete,
                                                        DataType = typeof(int),
                                                        SearchControlID = "Id",
                                                        SearchToolBarOperation = SearchOperation.Contains},
                                     new JQGridColumn { DataField = "Name", 
                                                        HeaderText = "เขตการศึกษา",
                                                        Editable = true,
                                                        Width = 300,
                                                        Searchable = true,
                                                        SearchType = SearchType.AutoComplete,
                                                        DataType = typeof(string),
                                                        SearchControlID = "Name",
                                                        SearchToolBarOperation = SearchOperation.Contains},
                                     new JQGridColumn { DataField = "Address", 
                                                        HeaderText = "ที่อยู่",
                                                        Editable = true,
                                                        Visible = false,
                                                        Width = 300,
                                                        Searchable = true,
                                                        SearchType = SearchType.AutoComplete,
                                                        DataType = typeof(string),
                                                        SearchControlID = "Address",
                                                        SearchToolBarOperation = SearchOperation.Contains},
                                     new JQGridColumn { DataField = "Tel1", 
                                                        HeaderText = "โทรศัพท์ 1",
                                                        Editable = true,
                                                        Visible = false,
                                                        Width = 300,
                                                        Searchable = true,
                                                        SearchType = SearchType.AutoComplete,
                                                        DataType = typeof(string),
                                                        SearchControlID = "Tel1",
                                                        SearchToolBarOperation = SearchOperation.Contains},
                                     new JQGridColumn { DataField = "Tel2", 
                                                        HeaderText = "โทรศัพท์ 2",
                                                        Editable = true,
                                                        Visible = false,
                                                        Width = 300,
                                                        Searchable = true,
                                                        SearchType = SearchType.AutoComplete,
                                                        DataType = typeof(string),
                                                        SearchControlID = "Tel2",
                                                        SearchToolBarOperation = SearchOperation.Contains},
                                     new JQGridColumn { DataField = "NumSchool", 
                                                        HeaderText = "จำนวนโรงเรียน",
                                                        Editable = false,
                                                        Width = 100,
                                                        Searchable = true,
                                                        SearchType = SearchType.AutoComplete,
                                                        DataType = typeof(int),
                                                        SearchControlID = "NumSchool",
                                                        SearchToolBarOperation = SearchOperation.Contains},
                                     new JQGridColumn { DataField = "TotallyTabletQuota", 
                                                        HeaderText = "จำนวนแท็บเล็ต",
                                                        Editable = false,
                                                        Width = 100,
                                                        Searchable = true,
                                                        SearchType = SearchType.AutoComplete,
                                                        DataType = typeof(int),
                                                        SearchControlID = "TotallyTabletQuota",
                                                        SearchToolBarOperation = SearchOperation.Contains},
                                     new JQGridColumn { DataField = "Supervisor", 
                                                        HeaderText = "ผู้รับผิดชอบ",
                                                        Editable = true,
                                                        Width = 200,
                                                        Searchable = true,
                                                        SearchType = SearchType.AutoComplete,
                                                        DataType = typeof(string),
                                                        SearchControlID = "Supervisor",
                                                        SearchToolBarOperation = SearchOperation.Contains},             
                                 },
                Width = Unit.Pixel(840)
            };

            DistrictMasterGrid.ToolBarSettings.ShowRefreshButton = true;
        }

        public JQGrid DistrictMasterGrid { get; set; }
    }

    public class SchoolMasterModel
    {
        public SchoolMasterModel()
        {
            JQGridColumn a = new JQGridColumn();
            SchoolMasterGrid = new JQGrid
            {
                Columns = new List<JQGridColumn>()
                                 {
                                     new JQGridColumn { DataField = "Id", 
                                                        HeaderText = "รหัส",
                                                        // always set PrimaryKey for Add,Edit,Delete operations
                                                        // if not set, the first column will be assumed as primary key
                                                        PrimaryKey = true,
                                                        Editable = false,
                                                        Width = 100,
                                                        Searchable = true,
                                                        SearchType = SearchType.AutoComplete,
                                                        DataType = typeof(int),
                                                        SearchControlID = "Id",
                                                        SearchToolBarOperation = SearchOperation.Contains},
                                     new JQGridColumn { DataField = "Name", 
                                                        HeaderText = "ชื่อโรงเรียน",
                                                        Editable = true,
                                                        Width = 300,
                                                        Searchable = true,
                                                        SearchType = SearchType.AutoComplete,
                                                        DataType = typeof(string),
                                                        SearchControlID = "Name",
                                                        SearchToolBarOperation = SearchOperation.Contains},
                                     new JQGridColumn { DataField = "Address", 
                                                        HeaderText = "ที่อยู่",
                                                        Editable = true,
                                                        Visible = false,
                                                        Width = 300,
                                                        Searchable = true,
                                                        SearchType = SearchType.AutoComplete,
                                                        DataType = typeof(string),
                                                        SearchControlID = "Address",
                                                        SearchToolBarOperation = SearchOperation.Contains},
                                     new JQGridColumn { DataField = "Tel1", 
                                                        HeaderText = "โทรศัพท์ 1",
                                                        Editable = true,
                                                        Visible = false,
                                                        Width = 300,
                                                        Searchable = true,
                                                        SearchType = SearchType.AutoComplete,
                                                        DataType = typeof(string),
                                                        SearchControlID = "Tel1",
                                                        SearchToolBarOperation = SearchOperation.Contains},
                                     new JQGridColumn { DataField = "Tel2", 
                                                        HeaderText = "โทรศัพท์ 2",
                                                        Editable = true,
                                                        Visible = false,
                                                        Width = 300,
                                                        Searchable = true,
                                                        SearchType = SearchType.AutoComplete,
                                                        DataType = typeof(string),
                                                        SearchControlID = "Tel2",
                                                        SearchToolBarOperation = SearchOperation.Contains},
                                     new JQGridColumn { DataField = "NumStudent", 
                                                        HeaderText = "จำนวนนักเรียน",
                                                        Editable = false,
                                                        Width = 100,
                                                        Searchable = true,
                                                        SearchType = SearchType.AutoComplete,
                                                        DataType = typeof(int),
                                                        SearchControlID = "NumStudent",
                                                        SearchToolBarOperation = SearchOperation.Contains},
                                     new JQGridColumn { DataField = "TabletQuota", 
                                                        HeaderText = "จำนวนแท็บเล็ต",
                                                        Editable = false,
                                                        Width = 100,
                                                        Searchable = true,
                                                        SearchType = SearchType.AutoComplete,
                                                        DataType = typeof(int),
                                                        SearchControlID = "TabletQuota",
                                                        SearchToolBarOperation = SearchOperation.Contains},
                                     new JQGridColumn { DataField = "Supervisor", 
                                                        HeaderText = "ผู้รับผิดชอบ",
                                                        Editable = true,
                                                        Width = 200,
                                                        Searchable = true,
                                                        SearchType = SearchType.AutoComplete,
                                                        DataType = typeof(string),
                                                        SearchControlID = "Supervisor",
                                                        SearchToolBarOperation = SearchOperation.Contains}              
                                 },
                Width = Unit.Pixel(840)
            };

            SchoolMasterGrid.ToolBarSettings.ShowRefreshButton = true;
        }

        public JQGrid SchoolMasterGrid { get; set; }
    }

    public class StudentMasterModel
    {
        public StudentMasterModel()
        {
            JQGridColumn a = new JQGridColumn();
            StudentMasterGrid = new JQGrid
            {
                Columns = new List<JQGridColumn>()
                                 {
                                     new JQGridColumn { DataField = "Id", 
                                                        HeaderText = "รหัส",
                                                        // always set PrimaryKey for Add,Edit,Delete operations
                                                        // if not set, the first column will be assumed as primary key
                                                        PrimaryKey = true,
                                                        Editable = false,
                                                        Visible = false,
                                                        Width = 100,
                                                        Searchable = true,
                                                        SearchType = SearchType.AutoComplete,
                                                        DataType = typeof(int),
                                                        SearchControlID = "Id",
                                                        SearchToolBarOperation = SearchOperation.Contains},
                                     new JQGridColumn { DataField = "IDNo", 
                                                        HeaderText = "หมายเลขประจำตัวประชาชน",
                                                        // always set PrimaryKey for Add,Edit,Delete operations
                                                        // if not set, the first column will be assumed as primary key
                                                        PrimaryKey = false,
                                                        Editable = true,
                                                        Width = 100,
                                                        Searchable = true,
                                                        SearchType = SearchType.AutoComplete,
                                                        DataType = typeof(int),
                                                        SearchControlID = "Id",
                                                        SearchToolBarOperation = SearchOperation.Contains},
                                     new JQGridColumn { DataField = "FirstName", 
                                                        HeaderText = "ชื่อ",
                                                        Editable = true,
                                                        Width = 150,
                                                        Searchable = true,
                                                        SearchType = SearchType.AutoComplete,
                                                        DataType = typeof(string),
                                                        SearchControlID = "FirstName",
                                                        SearchToolBarOperation = SearchOperation.Contains},
                                     new JQGridColumn { DataField = "LastName", 
                                                        HeaderText = "นามสกุล",
                                                        Editable = true,
                                                        Width = 150,
                                                        Searchable = true,
                                                        SearchType = SearchType.AutoComplete,
                                                        DataType = typeof(string),
                                                        SearchControlID = "LastName",
                                                        SearchToolBarOperation = SearchOperation.Contains},
                                     new JQGridColumn { DataField = "DistritName", 
                                                        HeaderText = "เขตการศึกษา",
                                                        Editable = true,
                                                        Width = 150,
                                                        Searchable = true,
                                                        SearchType = SearchType.AutoComplete,
                                                        DataType = typeof(string),
                                                        SearchControlID = "DistritName",
                                                        SearchToolBarOperation = SearchOperation.Contains},
                                     new JQGridColumn { DataField = "SchoolName", 
                                                        HeaderText = "โรงเรียน",
                                                        Editable = true,
                                                        Width = 150,
                                                        Searchable = true,
                                                        SearchType = SearchType.AutoComplete,
                                                        DataType = typeof(string),
                                                        SearchControlID = "SchoolName",
                                                        SearchToolBarOperation = SearchOperation.Contains},
                                     new JQGridColumn { DataField = "Address", 
                                                        HeaderText = "ที่อยู่",
                                                        Editable = true,
                                                        Width = 300,
                                                        Searchable = true,
                                                        SearchType = SearchType.AutoComplete,
                                                        DataType = typeof(string),
                                                        SearchControlID = "Address",
                                                        SearchToolBarOperation = SearchOperation.Contains},
                                     new JQGridColumn { DataField = "Tel", 
                                                        HeaderText = "เบอร์โทรศัพท์",
                                                        Editable = true,
                                                        Width = 100,
                                                        Searchable = true,
                                                        SearchType = SearchType.AutoComplete,
                                                        DataType = typeof(string),
                                                        SearchControlID = "Tel",
                                                        SearchToolBarOperation = SearchOperation.Contains}
                                 },
                Width = Unit.Pixel(840)
            };

            StudentMasterGrid.ToolBarSettings.ShowRefreshButton = true;
        }

        public JQGrid StudentMasterGrid { get; set; }
    }

    public class AdminSendTabletMasterModel
    {
        public AdminSendTabletMasterModel()
        {
            JQGridColumn a = new JQGridColumn();
            StudentMasterGrid = new JQGrid
            {
                Columns = new List<JQGridColumn>()
                                 {
                                     new JQGridColumn { DataField = "Id", 
                                                        HeaderText = "เลือก (chkbox)",
                                                        // always set PrimaryKey for Add,Edit,Delete operations
                                                        // if not set, the first column will be assumed as primary key
                                                        PrimaryKey = true,
                                                        Editable = false,
                                                        Width = 100,
                                                        Searchable = true,
                                                        SearchType = SearchType.AutoComplete,
                                                        DataType = typeof(int),
                                                        SearchControlID = "Id",
                                                        SearchToolBarOperation = SearchOperation.Contains},
                                     new JQGridColumn { DataField = "FirstName", 
                                                        HeaderText = "Serial Number",
                                                        Editable = true,
                                                        Width = 200,
                                                        Searchable = true,
                                                        SearchType = SearchType.AutoComplete,
                                                        DataType = typeof(string),
                                                        SearchControlID = "FirstName",
                                                        SearchToolBarOperation = SearchOperation.Contains},
                                     new JQGridColumn { DataField = "LastName", 
                                                        HeaderText = "Mac Address",
                                                        Editable = true,
                                                        Width = 200,
                                                        Searchable = true,
                                                        SearchType = SearchType.AutoComplete,
                                                        DataType = typeof(string),
                                                        SearchControlID = "LastName",
                                                        SearchToolBarOperation = SearchOperation.Contains},
                                     new JQGridColumn { DataField = "Address", 
                                                        HeaderText = "สี",
                                                        Editable = true,
                                                        Width = 300,
                                                        Searchable = true,
                                                        SearchType = SearchType.AutoComplete,
                                                        DataType = typeof(string),
                                                        SearchControlID = "Address",
                                                        SearchToolBarOperation = SearchOperation.Contains}  
                                 },
                Width = Unit.Pixel(840)
            };

            StudentMasterGrid.ToolBarSettings.ShowRefreshButton = true;
        }

        public JQGrid StudentMasterGrid { get; set; }
    }

    public class HomeNewsModel
    {
        public bool isAdmin { get; set; }
        public List<NNewsItem> NewsItems { get; set; }
    }

    public class TabletQueryModel
    {
        public int seq { get; set; }
        public string SerialNo { get; set; }
        public string MacAddress { get; set; }
        public string GoodNo { get; set; }
        public string Color { get; set; }
        public string Status { get; set; }
        public string LotNo { get; set; }
        public string Remark { get; set; }
        public string attachFile { get; set; }
    }

    public class TabletDeliveryDetailQueryModel
    {
        public string Name { get; set; }
        public string Inventory { get; set; }
        public Nullable<DateTime> Updated { get; set; }
    }

    public class TabletDeliveryDetailPageModel
    {
        public string TabletSerialNumber { get; set; }
        public TabletDeliveryDetailModel gridModel { get; set; }
    }

    public class TabletUserDetailQueryModel
    {
        public string SerialNumber { get; set; }
        public string MacAddress { get; set; }
        public Nullable<DateTime> Updated { get; set; }
    }

    public class TabletUserDetailPageModel
    {
        public string Name { get; set; }
        public int id { get; set; }
        public TabletUserDetailModel gridModel { get; set; }
    }

    public class TabletCountQueryModel
    {
        public string SerialNo { get; set; }
        public string MacAddress { get; set; }
        public string Color { get; set; }
        public Nullable<bool> IsAcceptable { get; set; }
        public Nullable<bool> IsChecking { get; set; }
        public Nullable<bool> IsChecked { get; set; }
        public Nullable<bool> IsLost { get; set; }
        public string CheckingRemark { get; set; }
        public Nullable<DateTime> StartCheckingTime { get; set; }
    }

    public class TabletCountConfirmQueryModel
    {
        public string SerialNo { get; set; }
        public string MacAddress { get; set; }
        public string Color { get; set; }
        public string IsAcceptable { get; set; }
        public Nullable<bool> IsChecking { get; set; }
        public Nullable<bool> IsLost { get; set; }
        public string CheckingRemark { get; set; }
        public Nullable<DateTime> StartCheckingTime { get; set; }
    }

    public class TabletMasterModel
    {
        public TabletMasterModel()
        {
            JQGridColumn a = new JQGridColumn();
            TabletMasterGrid = new JQGrid
            {
                Columns = new List<JQGridColumn>()
                                 {
                                     new JQGridColumn { DataField = "SerialNo", 
                                                        HeaderText = "หมายเลขเครื่อง (Serial No.)",
                                                        // always set PrimaryKey for Add,Edit,Delete operations
                                                        // if not set, the first column will be assumed as primary key
                                                        PrimaryKey = true,
                                                        Editable = false,
                                                        Width = 300,
                                                        Searchable = true,
                                                        SearchType = SearchType.AutoComplete,
                                                        DataType = typeof(string),
                                                        //SearchControlID = "Address",
                                                        SearchToolBarOperation = SearchOperation.Contains},
                                     new JQGridColumn { DataField = "MacAddress", 
                                                        HeaderText = "MacAddress",
                                                        Editable = true,
                                                        Width = 300,
                                                        Searchable = true,
                                                        SearchType = SearchType.AutoComplete,
                                                        DataType = typeof(string),
                                                        //SearchControlID = "Address",
                                                        SearchToolBarOperation = SearchOperation.Contains},
                                     new JQGridColumn { DataField = "LotNo", 
                                                        HeaderText = "หมายเลขล็อต",
                                                        Editable = true,
                                                        Width = 50,
                                                        Visible = true,
                                                        Searchable = true,
                                                        SearchType = SearchType.AutoComplete,
                                                        DataType = typeof(string),
                                                        SearchToolBarOperation = SearchOperation.Contains},
                                     new JQGridColumn { DataField = "Status", 
                                                        HeaderText = "สถานะ",
                                                        Editable = false,
                                                        Visible = false,
                                                        Width = 150,
                                                        Searchable = true,
                                                        SearchType = SearchType.AutoComplete,
                                                        DataType = typeof(string),
                                                        //SearchControlID = "Status",
                                                        SearchToolBarOperation = SearchOperation.Contains} 
                                 },
                Width = Unit.Pixel(840),
                Height = Unit.Pixel(300)
            };

            TabletMasterGrid.ToolBarSettings.ShowRefreshButton = true;
            TabletMasterGrid.PagerSettings.PageSize = 50;
            TabletMasterGrid.AppearanceSettings.AlternateRowBackground = true;
        }

        public JQGrid TabletMasterGrid { get; set; }
    }


    public class TabletDocumentMasterModel
    {
        public TabletDocumentMasterModel()
        {
            JQGridColumn a = new JQGridColumn();
            TabletMasterGrid = new JQGrid
            {
                Columns = new List<JQGridColumn>()
                                 {
                                     new JQGridColumn { DataField = "SerialNo", 
                                                        HeaderText = "หมายเลขเครื่อง (Serial No.)",
                                                        // always set PrimaryKey for Add,Edit,Delete operations
                                                        // if not set, the first column will be assumed as primary key
                                                        PrimaryKey = true,
                                                        Editable = false,
                                                        Width = 200,
                                                        Searchable = true,
                                                        SearchType = SearchType.AutoComplete,
                                                        DataType = typeof(string),
                                                        //SearchControlID = "Address",
                                                        SearchToolBarOperation = SearchOperation.Contains},
                                     new JQGridColumn { DataField = "MacAddress", 
                                                        HeaderText = "MacAddress",
                                                        Editable = true,
                                                        Width = 200,
                                                        Searchable = true,
                                                        SearchType = SearchType.AutoComplete,
                                                        DataType = typeof(string),
                                                        //SearchControlID = "Address",
                                                        SearchToolBarOperation = SearchOperation.Contains},
                                     new JQGridColumn { DataField = "LotNo", 
                                                        HeaderText = "หมายเลขล็อต",
                                                        Editable = true,
                                                        Width = 50,
                                                        Visible = true,
                                                        Searchable = true,
                                                        SearchType = SearchType.AutoComplete,
                                                        DataType = typeof(string),
                                                        SearchToolBarOperation = SearchOperation.Contains},
                                     new JQGridColumn { DataField = "Remark", 
                                                        HeaderText = "หมายเหตุ",
                                                        Editable = true,
                                                        Width = 200,
                                                        Visible = true,
                                                        Searchable = true,
                                                        SearchType = SearchType.AutoComplete,
                                                        DataType = typeof(string),
                                                        SearchToolBarOperation = SearchOperation.Contains},
                                     new JQGridColumn { DataField = "attachFile", 
                                                        HeaderText = "File",
                                                        Editable = true,
                                                        Width = 0,
                                                        Visible = false,
                                                        Searchable = true,
                                                        SearchType = SearchType.AutoComplete,
                                                        DataType = typeof(string),
                                                        SearchToolBarOperation = SearchOperation.Contains}
                                 },
                Width = Unit.Pixel(840),
                Height = Unit.Pixel(300)
            };

            TabletMasterGrid.ToolBarSettings.ShowRefreshButton = true;
            TabletMasterGrid.PagerSettings.PageSize = 50;
            TabletMasterGrid.AppearanceSettings.AlternateRowBackground = true;
        }

        public JQGrid TabletMasterGrid { get; set; }
    }

    public class TabletDeliveryDetailModel
    {
        public TabletDeliveryDetailModel()
        {
            JQGridColumn a = new JQGridColumn();
            TabletDeliveryDetailGrid = new JQGrid
            {
                Columns = new List<JQGridColumn>()
                                 {
                                     new JQGridColumn { DataField = "Name", 
                                                        HeaderText = "ผู้ถือครอง",
                                                        // always set PrimaryKey for Add,Edit,Delete operations
                                                        // if not set, the first column will be assumed as primary key
                                                        PrimaryKey = true,
                                                        Editable = true,
                                                        Width = 200,
                                                        Searchable = true,
                                                        SearchType = SearchType.AutoComplete,
                                                        DataType = typeof(string),
                                                        //SearchControlID = "Address",
                                                        SearchToolBarOperation = SearchOperation.Contains},
                                     new JQGridColumn { DataField = "Inventory", 
                                                        HeaderText = "คลังที่จัดเก็บ",
                                                        Editable = true,
                                                        Width = 200,
                                                        Searchable = true,
                                                        SearchType = SearchType.AutoComplete,
                                                        DataType = typeof(string),
                                                        SearchToolBarOperation = SearchOperation.Contains},
                                     new JQGridColumn { DataField = "Updated", 
                                                        HeaderText = "วันที่",
                                                        Editable = true,
                                                        Width = 200,
                                                        Searchable = true,
                                                        SearchType = SearchType.AutoComplete,
                                                        DataType = typeof(DateTime),
                                                        DataFormatString = "{0:dd/MM/yyyy H:m:s}",
                                                        SearchToolBarOperation = SearchOperation.Contains}
                                 },
                Width = Unit.Pixel(840),
                Height = Unit.Pixel(300)
            };

            TabletDeliveryDetailGrid.ToolBarSettings.ShowRefreshButton = true;
            TabletDeliveryDetailGrid.PagerSettings.PageSize = 50;
            TabletDeliveryDetailGrid.AppearanceSettings.AlternateRowBackground = true;
        }

        public JQGrid TabletDeliveryDetailGrid { get; set; }
    }

    public class TabletUserDetailModel
    {
        public TabletUserDetailModel()
        {
            JQGridColumn a = new JQGridColumn();
            TabletUserDetailGrid = new JQGrid
            {
                Columns = new List<JQGridColumn>()
                                 {
                                     new JQGridColumn { DataField = "SerialNumber", 
                                                        HeaderText = "หมายเลขเครื่อง",
                                                        // always set PrimaryKey for Add,Edit,Delete operations
                                                        // if not set, the first column will be assumed as primary key
                                                        PrimaryKey = true,
                                                        Editable = true,
                                                        Width = 200,
                                                        Searchable = true,
                                                        SearchType = SearchType.AutoComplete,
                                                        DataType = typeof(string),
                                                        //SearchControlID = "Address",
                                                        SearchToolBarOperation = SearchOperation.Contains},
                                     new JQGridColumn { DataField = "MacAddress", 
                                                        HeaderText = "Mac Address",
                                                        Editable = true,
                                                        Width = 200,
                                                        Searchable = true,
                                                        SearchType = SearchType.AutoComplete,
                                                        DataType = typeof(string),
                                                        SearchToolBarOperation = SearchOperation.Contains},
                                     new JQGridColumn { DataField = "Updated", 
                                                        HeaderText = "วันที่",
                                                        Editable = true,
                                                        Width = 200,
                                                        Searchable = true,
                                                        SearchType = SearchType.AutoComplete,
                                                        DataType = typeof(DateTime),
                                                        SearchToolBarOperation = SearchOperation.Contains}
                                 },
                Width = Unit.Pixel(840),
                Height = Unit.Pixel(600)
            };

            TabletUserDetailGrid.ToolBarSettings.ShowRefreshButton = true;
            TabletUserDetailGrid.PagerSettings.PageSize = 50;
            TabletUserDetailGrid.AppearanceSettings.AlternateRowBackground = true;
        }

        public JQGrid TabletUserDetailGrid { get; set; }
    }

    public class TabletCountModel
    {
        public TabletCountModel()
        {
            JQGridColumn a = new JQGridColumn();
            TabletCountGrid = new JQGrid
            {
                Columns = new List<JQGridColumn>()
                                 {
                                     new JQGridColumn { DataField = "SerialNo", 
                                                        HeaderText = "หมายเลขเครื่อง (Serial no.)",
                                                        // always set PrimaryKey for Add,Edit,Delete operations
                                                        // if not set, the first column will be assumed as primary key
                                                        PrimaryKey = true,
                                                        Editable = true,
                                                        Width = 200,
                                                        Searchable = true,
                                                        SearchType = SearchType.AutoComplete,
                                                        DataType = typeof(string),
                                                        //SearchControlID = "Address",
                                                        SearchToolBarOperation = SearchOperation.Contains},
                                     new JQGridColumn { DataField = "MacAddress", 
                                                        HeaderText = "MacAddress",
                                                        // always set PrimaryKey for Add,Edit,Delete operations
                                                        // if not set, the first column will be assumed as primary key
                                                        Editable = false,
                                                        Width = 150,
                                                        Searchable = true,
                                                        SearchType = SearchType.AutoComplete,
                                                        DataType = typeof(string),
                                                        //SearchControlID = "Address",
                                                        SearchToolBarOperation = SearchOperation.Contains},
                                     new JQGridColumn { DataField = "Color", 
                                                        HeaderText = "สี",
                                                        // always set PrimaryKey for Add,Edit,Delete operations
                                                        // if not set, the first column will be assumed as primary key
                                                        Editable = false,
                                                        Width = 50,
                                                        Searchable = true,
                                                        SearchType = SearchType.AutoComplete,
                                                        DataType = typeof(string),
                                                        //SearchControlID = "Address",
                                                        SearchToolBarOperation = SearchOperation.Contains},
                                     new JQGridColumn { DataField = "IsChecking", 
                                                        HeaderText = "กำลังตรวจรับ",
                                                        Width = 50,
                                                        Editable = false,
                                                        Visible = false,
                                                        Searchable = true,
                                                        SearchType = SearchType.AutoComplete,
                                                        DataType = typeof(bool),
                                                        EditType = Trirand.Web.Mvc.EditType.CheckBox,
                                                        //SearchControlID = "Address",
                                                        SearchToolBarOperation = SearchOperation.Contains},
                                     new JQGridColumn { DataField = "IsAcceptable", 
                                                        HeaderText = "ผลการตรวจรับ",
                                                        Editable = true,
                                                        Width = 50,
                                                        Visible = false,
                                                        Searchable = true,
                                                        SearchType = SearchType.AutoComplete,
                                                        DataType = typeof(string),
                                                        EditType = Trirand.Web.Mvc.EditType.DropDown,
                                                        //SearchControlID = "Address",
                                                        SearchToolBarOperation = SearchOperation.Contains},
                                     new JQGridColumn { DataField = "IsLost", 
                                                        HeaderText = "ไม่ได้รับภายในล็อต",
                                                        Editable = false,
                                                        Width = 50,
                                                        Visible = false,
                                                        Searchable = true,
                                                        SearchType = SearchType.AutoComplete,
                                                        DataType = typeof(bool),
                                                        EditType = Trirand.Web.Mvc.EditType.CheckBox,
                                                        //SearchControlID = "Address",
                                                        SearchToolBarOperation = SearchOperation.Contains},
                                     new JQGridColumn { DataField = "CheckingRemark", 
                                                        HeaderText = "หมายเหตุ",
                                                        Editable = true,
                                                        Width = 300,
                                                        Searchable = true,
                                                        Visible = false,
                                                        SearchType = SearchType.AutoComplete,
                                                        DataType = typeof(string),
                                                        //SearchControlID = "GoodNo",
                                                        SearchToolBarOperation = SearchOperation.Contains},
                                     new JQGridColumn { DataField = "StartCheckingTime",
                                                        Editable = false,
                                                        Visible = false,
                                                        DataType = typeof(DateTime)},
                                     new JQGridColumn { DataField = "IsChecked", 
                                                        HeaderText = "ตรวจสอบแล้ว",
                                                        Width = 50,
                                                        Editable = false,
                                                        Visible = false,
                                                        Searchable = true,
                                                        SearchType = SearchType.AutoComplete,
                                                        DataType = typeof(bool),
                                                        //SearchControlID = "Address",
                                                        SearchToolBarOperation = SearchOperation.Contains},
                                 },
                Width = Unit.Pixel(840),
                Height = Unit.Pixel(300)
            };

            TabletCountGrid.ToolBarSettings.ShowRefreshButton = true;
            TabletCountGrid.PagerSettings.PageSize = 10;
            TabletCountGrid.AppearanceSettings.AlternateRowBackground = true;
        }

        public JQGrid TabletCountGrid { get; set; }
        public string LotID { get; set; }
        public string Seq { get; set; }
        public string LotNo { get; set; }
        public string DeliveryLotID { get; set; }
    }

    public class AdminReceiveTabletModel
    {
        public AdminReceiveTabletModel()
        {
            JQGridColumn a = new JQGridColumn();
            TabletCountGrid = new JQGrid
            {
                Columns = new List<JQGridColumn>()
                                 {
                                     new JQGridColumn { DataField = "SerialNo", 
                                                        HeaderText = "Serial Number",
                                                        // always set PrimaryKey for Add,Edit,Delete operations
                                                        // if not set, the first column will be assumed as primary key
                                                        PrimaryKey = true,
                                                        Editable = true,
                                                        Width = 100,
                                                        Searchable = true,
                                                        SearchType = SearchType.AutoComplete,
                                                        DataType = typeof(string),
                                                        //SearchControlID = "Address",
                                                        SearchToolBarOperation = SearchOperation.Contains},
                                     new JQGridColumn { DataField = "MacAddress", 
                                                        HeaderText = "MacAddress",
                                                        // always set PrimaryKey for Add,Edit,Delete operations
                                                        // if not set, the first column will be assumed as primary key
                                                        Editable = false,
                                                        Width = 100,
                                                        Searchable = true,
                                                        SearchType = SearchType.AutoComplete,
                                                        DataType = typeof(string),
                                                        //SearchControlID = "Address",
                                                        SearchToolBarOperation = SearchOperation.Contains},
                                     new JQGridColumn { DataField = "MacAddress", 
                                                        HeaderText = "สี",
                                                        // always set PrimaryKey for Add,Edit,Delete operations
                                                        // if not set, the first column will be assumed as primary key
                                                        Editable = false,
                                                        Width = 100,
                                                        Searchable = true,
                                                        SearchType = SearchType.AutoComplete,
                                                        DataType = typeof(string),
                                                        //SearchControlID = "Address",
                                                        SearchToolBarOperation = SearchOperation.Contains},
                                     new JQGridColumn { DataField = "MacAddress", 
                                                        HeaderText = "ส่งจาก",
                                                        // always set PrimaryKey for Add,Edit,Delete operations
                                                        // if not set, the first column will be assumed as primary key
                                                        Editable = false,
                                                        Width = 100,
                                                        Searchable = true,
                                                        SearchType = SearchType.AutoComplete,
                                                        DataType = typeof(string),
                                                        //SearchControlID = "Address",
                                                        SearchToolBarOperation = SearchOperation.Contains},
                                     new JQGridColumn { DataField = "IsAcceptable", 
                                                        HeaderText = "ตรวจรับผ่าน",
                                                        Editable = true,
                                                        Width = 50,
                                                        Visible = false,
                                                        Searchable = true,
                                                        SearchType = SearchType.AutoComplete,
                                                        DataType = typeof(bool),
                                                        EditType = Trirand.Web.Mvc.EditType.CheckBox,
                                                        //SearchControlID = "Address",
                                                        SearchToolBarOperation = SearchOperation.Contains},
                                     new JQGridColumn { DataField = "CheckingRemark", 
                                                        HeaderText = "หมายเหตุ",
                                                        Editable = true,
                                                        Width = 300,
                                                        Searchable = true,
                                                        Visible = false,
                                                        SearchType = SearchType.AutoComplete,
                                                        DataType = typeof(string),
                                                        //SearchControlID = "GoodNo",
                                                        SearchToolBarOperation = SearchOperation.Contains},
                                     new JQGridColumn { DataField = "StartCheckingTime",
                                                        Editable = false,
                                                        Visible = false,
                                                        DataType = typeof(DateTime)}
                                 },
                Width = Unit.Pixel(840),
                Height = Unit.Pixel(300)
            };

            TabletCountGrid.ToolBarSettings.ShowRefreshButton = true;
            TabletCountGrid.PagerSettings.PageSize = 10;
            TabletCountGrid.AppearanceSettings.AlternateRowBackground = true;
        }

        public JQGrid TabletCountGrid { get; set; }
        public string LotID { get; set; }
        public string Seq { get; set; }
        public string LotNo { get; set; }
        public string DeliveryLotID { get; set; }
    }

    public class TabletSelectModel
    {
        public int Id { get; set; }
        public int Seq { get; set; }
        public string LotNo { get; set; }
        public Nullable<int> PlannedTabletCount { get; set; }
        public Nullable<int> PlannedPalletCount { get; set; }
        public Nullable<DateTime> PlannedSendDate { get; set; }
        public Nullable<DateTime> PlannedReceivedDate { get; set; }
    }

    public class TabletReportModel
    {
        public string TabletSerialNo { get; set; }
        public string MacAddress { get; set; }
        public string CheckingRemark { get; set; }
        public Nullable<bool> IsChecked { get; set; }
        public Nullable<bool> IsAcceptable { get; set; }
        public Nullable<DateTime> Updated { get; set; }
        public Nullable<int> CheckingTimeLength { get; set; }
        public Nullable<bool> IsChecking { get; set; }
    }

    public class ClaimReportDataModel
    {
        public string tabletSerailNo { get; set; }
        public Nullable<DateTime> claimSendDate { get; set; }
        public Nullable<DateTime> claimRevieveDate { get; set; }
        public string claimRemark { get; set; }
        public string claimStatus { get; set; }
        public int claimCount { get; set; }
        public string tabletStatus { get; set; }
        public string macAddress { get; set; }
        public string newTabletSerial { get; set; }
    }

    public class LostTabletReportDataModel
    {
        public string serailNumber { get; set; }
        public string macAddress { get; set; }
        public Boolean isReplace { get; set; }
        public string newSerial { get; set; }
    }

    public class TabletCountSelectModel
    {
        public TabletCountSelectModel()
        {
            JQGridColumn a = new JQGridColumn();
            TabletCountSelectGrid = new JQGrid
            {
                Columns = new List<JQGridColumn>()
                                 {
                                     new JQGridColumn { DataField = "Seq", 
                                                        HeaderText = "ลำดับ",
                                                        Editable = true,
                                                        Width = 70,
                                                        Searchable = false,
                                                        SearchType = SearchType.AutoComplete,
                                                        DataType = typeof(int),
                                                        SearchControlID = "Seq",
                                                        SearchToolBarOperation = SearchOperation.Contains},
                                     new JQGridColumn { DataField = "Id", 
                                                        HeaderText = "รหัสล็อต",
                                                        PrimaryKey = true,
                                                        Visible = false,
                                                        Editable = false,
                                                        Width = 70},
                                     new JQGridColumn { DataField = "LotNo", 
                                                        HeaderText = "หมายเลขล็อต",
                                                        Editable = true,
                                                        Width = 100,
                                                        Searchable = true,
                                                        SearchType = SearchType.AutoComplete,
                                                        DataType = typeof(int),
                                                        SearchControlID = "LotNo",
                                                        SearchToolBarOperation = SearchOperation.Contains},
                                     new JQGridColumn { DataField = "PlannedPalletCount", 
                                                        HeaderText = "จำนวนพาเล็ต",
                                                        Width = 100, 
                                                        Editable = true,
                                                        Searchable = false,
                                                        SearchType = SearchType.AutoComplete,
                                                        DataType = typeof(int),
                                                        SearchControlID = "PlannedPalletCount",
                                                        SearchToolBarOperation = SearchOperation.Contains},
                                     new JQGridColumn { DataField = "PlannedTabletCount", 
                                                        HeaderText = "จำนวนแท็บเล็ต",
                                                        Width = 100, 
                                                        Editable = true,
                                                        Searchable = false,
                                                        SearchType = SearchType.AutoComplete,
                                                        DataType = typeof(int),
                                                        SearchControlID = "PlannedTabletCount",
                                                        SearchToolBarOperation = SearchOperation.Contains},
                                     new JQGridColumn { DataField = "PlannedSendDate", 
                                                        HeaderText = "วันที่ส่ง",
                                                        Editable = true,
                                                        Searchable = false,
                                                        Width = 120, 
                                                        DataFormatString = "{0:dd/MM/yyyy}" }, 
                                     new JQGridColumn { DataField = "PlannedReceivedDate", 
                                                        HeaderText = "วันที่รับ",
                                                        Editable = true,
                                                        Searchable = false,
                                                        Width = 120, 
                                                        DataFormatString = "{0:dd/MM/yyyy}" }          
                                 },
                Width = Unit.Pixel(840),
                Height = Unit.Pixel(200)
            };

            TabletCountSelectGrid.ToolBarSettings.ShowRefreshButton = true;
        }

        public JQGrid TabletCountSelectGrid { get; set; }
    }

    public class TabletCountReportModel
    {
        public TabletCountReportModel()
        {
            JQGridColumn a = new JQGridColumn();
            TabletCountReportGrid = new JQGrid
            {
                Columns = new List<JQGridColumn>()
                                 {
                                     new JQGridColumn { DataField = "TabletSerialNo", 
                                                        HeaderText = "หมายเลขเครื่อง",
                                                        Width = 120,
                                                        Searchable = true,
                                                        SearchType = SearchType.AutoComplete,
                                                        DataType = typeof(int),
                                                        SearchControlID = "TabletSerialNo",
                                                        SearchToolBarOperation = SearchOperation.Contains},
                                     new JQGridColumn { DataField = "MacAddress", 
                                                        HeaderText = "MacAddress",
                                                        Visible = true,
                                                        Editable = false,
                                                        Width = 100},
                                     new JQGridColumn { DataField = "IsChecking", 
                                                        HeaderText = "กำลังตรวจรับ",
                                                        Width = 50,
                                                        Editable = false,
                                                        Visible = true,
                                                        Searchable = false,
                                                        SearchType = SearchType.AutoComplete,
                                                        DataType = typeof(bool),
                                                        EditType = Trirand.Web.Mvc.EditType.CheckBox,
                                                        //SearchControlID = "Address",
                                                        SearchToolBarOperation = SearchOperation.Contains},
                                     new JQGridColumn { DataField = "IsChecked", 
                                                        HeaderText = "ตรวจรับแล้ว",
                                                        Width = 50,
                                                        Searchable = false,
                                                        SearchType = SearchType.AutoComplete,
                                                        DataType = typeof(bool),
                                                        SearchControlID = "IsChecked",
                                                        SearchToolBarOperation = SearchOperation.Contains},
                                     new JQGridColumn { DataField = "IsAcceptable", 
                                                        HeaderText = "ตรวจรับผ่าน",
                                                        Width = 50,
                                                        Searchable = false,
                                                        SearchType = SearchType.AutoComplete,
                                                        DataType = typeof(bool),
                                                        SearchControlID = "IsAcceptable",
                                                        SearchToolBarOperation = SearchOperation.Contains},
                                     new JQGridColumn { DataField = "CheckingRemark", 
                                                        HeaderText = "ผลการตรวจสอบคุณภาพ",
                                                        Width = 200, 
                                                        Searchable = false,
                                                        SearchType = SearchType.AutoComplete,
                                                        DataType = typeof(string),
                                                        SearchControlID = "CheckingRemark",
                                                        SearchToolBarOperation = SearchOperation.Contains},
                                     new JQGridColumn { DataField = "CheckingTimeLength", 
                                                        HeaderText = "ระยะเวลาตรวจรับ (นาที)",
                                                        Searchable = false,
                                                        DataType = typeof(Int32),
                                                        Width = 50},
                                     new JQGridColumn { DataField = "Updated", 
                                                        HeaderText = "วันที่ตรวจรับเสร็จ",
                                                        Searchable = false,
                                                        Width = 100, 
                                                        DataFormatString = "{0:d}"  }    
                                 },
                Width = Unit.Pixel(840),
                Height = Unit.Pixel(300)
            };

            TabletCountReportGrid.ToolBarSettings.ShowRefreshButton = true;
        }

        public JQGrid TabletCountReportGrid { get; set; }
        public int AllCount { get; set; }
        public int AcceptedCount { get; set; }
        public int RejectedCount { get; set; }
        public int CheckedCount { get; set; }
        public int CheckingCount { get; set; }
        public string LotNo { get; set; }
        public int DeliveryLotID { get; set; }
        public string CheckDate { get; set; }
    }

    public class ToRepairModel
    {
        public ToRepairModel()
        {
            JQGridColumn a = new JQGridColumn();
            ToRepairGrid = new JQGrid
            {
                Columns = new List<JQGridColumn>()
                                 {
                                     new JQGridColumn { DataField = "SerialNo", 
                                                        HeaderText = "Serial Number",
                                                        // always set PrimaryKey for Add,Edit,Delete operations
                                                        // if not set, the first column will be assumed as primary key
                                                        PrimaryKey = true,
                                                        Editable = true,
                                                        Width = 200,
                                                        Searchable = true,
                                                        SearchType = SearchType.AutoComplete,
                                                        DataType = typeof(string),
                                                        //SearchControlID = "Address",
                                                        SearchToolBarOperation = SearchOperation.Contains},
                                     new JQGridColumn { DataField = "MacAddress", 
                                                        HeaderText = "MacAddress",
                                                        // always set PrimaryKey for Add,Edit,Delete operations
                                                        // if not set, the first column will be assumed as primary key
                                                        Editable = false,
                                                        Width = 200,
                                                        Searchable = true,
                                                        SearchType = SearchType.AutoComplete,
                                                        DataType = typeof(string),
                                                        //SearchControlID = "Address",
                                                        SearchToolBarOperation = SearchOperation.Contains},
                                     new JQGridColumn { DataField = "IsAcceptable", 
                                                        HeaderText = "ตรวจรับผ่าน",
                                                        Editable = true,
                                                        Width = 50,
                                                        Visible = false,
                                                        Searchable = true,
                                                        SearchType = SearchType.AutoComplete,
                                                        DataType = typeof(bool),
                                                        EditType = Trirand.Web.Mvc.EditType.CheckBox,
                                                        //SearchControlID = "Address",
                                                        SearchToolBarOperation = SearchOperation.Contains},
                                     new JQGridColumn { DataField = "CheckingRemark", 
                                                        HeaderText = "หมายเหตุ",
                                                        Editable = true,
                                                        Width = 300,
                                                        Searchable = true,
                                                        Visible = false,
                                                        SearchType = SearchType.AutoComplete,
                                                        DataType = typeof(string),
                                                        //SearchControlID = "GoodNo",
                                                        SearchToolBarOperation = SearchOperation.Contains},
                                     new JQGridColumn { DataField = "StartCheckingTime",
                                                        Editable = false,
                                                        Visible = false,
                                                        DataType = typeof(DateTime)}
                                 },
                Width = Unit.Pixel(840),
                Height = Unit.Pixel(300)
            };

            ToRepairGrid.ToolBarSettings.ShowRefreshButton = true;
            ToRepairGrid.PagerSettings.PageSize = 10;
            ToRepairGrid.AppearanceSettings.AlternateRowBackground = true;
        }

        public JQGrid ToRepairGrid { get; set; }
    }

    public class ClaimCenterMasterModel
    {
        public ClaimCenterMasterModel()
        {
            JQGridColumn a = new JQGridColumn();
            ClaimCenterMasterGrid = new JQGrid
            {
                Columns = new List<JQGridColumn>()
                                 {
                                     new JQGridColumn { DataField = "Id", 
                                                        HeaderText = "รหัสศูนย์ซ่อม",
                                                        // always set PrimaryKey for Add,Edit,Delete operations
                                                        // if not set, the first column will be assumed as primary key
                                                        PrimaryKey = true,
                                                        Editable = false,
                                                        Width = 100,
                                                        Searchable = true,
                                                        Visible = false,
                                                        SearchType = SearchType.AutoComplete,
                                                        DataType = typeof(int),
                                                        SearchControlID = "Id",
                                                        SearchToolBarOperation = SearchOperation.Contains},
                                     new JQGridColumn { DataField = "Name", 
                                                        HeaderText = "ชื๋อศูนย์ซ่อม",
                                                        Editable = true,
                                                        Width = 300,
                                                        Searchable = true,
                                                        SearchType = SearchType.AutoComplete,
                                                        DataType = typeof(string),
                                                        SearchControlID = "Name",
                                                        SearchToolBarOperation = SearchOperation.Contains},
                                     new JQGridColumn { DataField = "Address", 
                                                        HeaderText = "ที่อยู่",
                                                        Editable = true,
                                                        Width = 300,
                                                        Searchable = true,
                                                        SearchType = SearchType.AutoComplete,
                                                        DataType = typeof(string),
                                                        SearchControlID = "Address",
                                                        SearchToolBarOperation = SearchOperation.Contains},     
                                     new JQGridColumn { DataField = "Phone", 
                                                        HeaderText = "โทรศัพท์",
                                                        Editable = true,
                                                        Width = 100,
                                                        Searchable = true,
                                                        SearchType = SearchType.AutoComplete,
                                                        DataType = typeof(string),
                                                        SearchControlID = "Phone",
                                                        SearchToolBarOperation = SearchOperation.Contains},
                                     new JQGridColumn { DataField = "Fax", 
                                                        HeaderText = "โทรสาร",
                                                        Editable = true,
                                                        Width = 100,
                                                        Searchable = true,
                                                        SearchType = SearchType.AutoComplete,
                                                        DataType = typeof(string),
                                                        SearchControlID = "Fax",
                                                        SearchToolBarOperation = SearchOperation.Contains},     
                                    new JQGridColumn { DataField = "ContactName", 
                                                        HeaderText = "ชื่อผู้ติดต่อ",
                                                        Editable = false,
                                                        Visible = false,
                                                        Width = 300,
                                                        Searchable = true,
                                                        SearchType = SearchType.AutoComplete,
                                                        DataType = typeof(string),
                                                        SearchControlID = "ContactName",
                                                        SearchToolBarOperation = SearchOperation.Contains}
                                 },
                Width = Unit.Pixel(840)
            };

            ClaimCenterMasterGrid.ToolBarSettings.ShowRefreshButton = true;
        }

        public JQGrid ClaimCenterMasterGrid { get; set; }
    }

    public class NewsMasterModel
    {
        public NewsMasterModel()
        {
            JQGridColumn a = new JQGridColumn();
            NewsListGrid = new JQGrid
            {
                Columns = new List<JQGridColumn>()
                                 {
                                     new JQGridColumn { DataField = "Id", 
                                                        HeaderText = "เลขที่",
                                                        // always set PrimaryKey for Add,Edit,Delete operations
                                                        // if not set, the first column will be assumed as primary key
                                                        PrimaryKey = true,
                                                        Editable = false,
                                                        Width = 200,
                                                        Visible = false,
                                                        Searchable = true,
                                                        SearchType = SearchType.AutoComplete,
                                                        DataType = typeof(string),
                                                        //SearchControlID = "Address",
                                                        SearchToolBarOperation = SearchOperation.Contains},
                                     new JQGridColumn { DataField = "Title", 
                                                        HeaderText = "หัวข้อ",
                                                        // always set PrimaryKey for Add,Edit,Delete operations
                                                        // if not set, the first column will be assumed as primary key
                                                        Editable = true,
                                                        Width = 400,
                                                        Searchable = true,
                                                        SearchType = SearchType.AutoComplete,
                                                        DataType = typeof(string),
                                                        //SearchControlID = "Address",
                                                        SearchToolBarOperation = SearchOperation.Contains},
                                     new JQGridColumn { DataField = "Date", 
                                                        HeaderText = "วันที่ประกาศ",
                                                        Editable = true,
                                                        Width = 300,
                                                        Searchable = true,
                                                        SearchType = SearchType.AutoComplete,
                                                        DataType = typeof(DateTime),
                                                        SearchToolBarOperation = SearchOperation.Contains},
                                     new JQGridColumn { DataField = "Published", 
                                                        HeaderText = "สถานะการเผยแพร่",
                                                        Editable = false,
                                                        Visible = true,
                                                        Width = 100,
                                                        Searchable = true,
                                                        SearchType = SearchType.AutoComplete,
                                                        DataType = typeof(string),
                                                        //SearchControlID = "Status",
                                                        SearchToolBarOperation = SearchOperation.Contains},
                                     new JQGridColumn { DataField = "ReadCount", 
                                                        HeaderText = "จำนวนครั้งที่อ่าน",
                                                        Editable = false,
                                                        Visible = false,
                                                        Width = 100,
                                                        Searchable = true,
                                                        SearchType = SearchType.AutoComplete,
                                                        DataType = typeof(string),
                                                        //SearchControlID = "Status",
                                                        SearchToolBarOperation = SearchOperation.Contains} 
                                 },
                Width = Unit.Pixel(840),
                Height = Unit.Pixel(400)
            };

            NewsListGrid.ToolBarSettings.ShowRefreshButton = true;
            NewsListGrid.PagerSettings.PageSize = 50;
            NewsListGrid.AppearanceSettings.AlternateRowBackground = true;
        }

        public JQGrid NewsListGrid { get; set; }
    }
}
