
jQuery(document).ready(function () {



});

function ShowReportClaimBySchool() {
    var url, Data;
    url = "../Report/ShowReportClaimBySchool";

    jQuery.ajax({
        type: "POST",
        url: url,
        cache: false,
        success: function (response) {
            //jAlert("error", response.text, "Error Dialog");
        },
        error: function (response) {
            jAlert("error", "ไม่สามารถโหลดรายงานนี้ได้", "ข้อผิดพลาด");
        },
        complete: function (response) {
        }
    });
}

function ShowReportClaimByDistrict() {
    var url, Data;
    url = "../Report/ShowReportClaimByDistrict";

    jQuery.ajax({
        type: "POST",
        url: url,
        cache: false,
        success: function (response) {
            //jAlert("error", response.text, "Error Dialog");
        },
        error: function (response) {
            jAlert("error", "ไม่สามารถโหลดรายงานนี้ได้", "ข้อผิดพลาด");
        },
        complete: function (response) {
        }
    });
}

function ShowReportLostBySchool() {
    var url, Data;
    url = "../Report/ShowReportLostBySchool";

    jQuery.ajax({
        type: "POST",
        url: url,
        cache: false,
        success: function (response) {
            //jAlert("error", response.text, "Error Dialog");
        },
        error: function (response) {
            jAlert("error", "ไม่สามารถโหลดรายงานนี้ได้", "ข้อผิดพลาด");
        },
        complete: function (response) {
        }
    });
}

function ShowReportLostByDistrict() {
    var url, Data;
    url = "../Report/ShowReportLostByDistrict";

    jQuery.ajax({
        type: "POST",
        url: url,
        cache: false,
        success: function (response) {
            //jAlert("error", response.text, "Error Dialog");
        },
        error: function (response) {
            jAlert("error", "ไม่สามารถโหลดรายงานนี้ได้", "ข้อผิดพลาด");
        },
        complete: function (response) {
        }
    });
}


function ShowReportTabletByLocationAll() {
    var url, Data;
    url = "../Report/ShowReportTabletByLocationAll";

    jQuery.ajax({
        type: "POST",
        url: url,
        cache: false,
        success: function (response) {
            //jAlert("error", response.text, "Error Dialog");
        },
        error: function (response) {
            jAlert("error", "ไม่สามารถโหลดรายงานนี้ได้", "ข้อผิดพลาด");
        },
        complete: function (response) {
        }
    });
}

function ShowReportTabletByLocation(stationTypeID, stationID, schoolID) {
    var url, Data;
    url = "../Report/ShowReportTabletByLocation";

    jQuery.ajax({
        type: "POST",
        url: url,
        data: {
            stationTypeID: stationTypeID,
            stationID: stationID,
            schoolID: schoolID
        },
        cache: false,
        success: function (response) {
            //jAlert("error", response.text, "Error Dialog");
        },
        error: function (response) {
            jAlert("error", "ไม่สามารถโหลดรายงานนี้ได้", "ข้อผิดพลาด");
        },
        complete: function (response) {
        }
    });
}

function ShowReportTabletMoveAll() {
    var url, Data;
    url = "../Report/ShowReportTabletMoveAll";

    jQuery.ajax({
        type: "POST",
        url: url,
        cache: false,
        success: function (response) {
            //jAlert("error", response.text, "Error Dialog");
        },
        error: function (response) {
            jAlert("error", "ไม่สามารถโหลดรายงานนี้ได้", "ข้อผิดพลาด");
        },
        complete: function (response) {
        }
    });
}

function ShowReportTabletByInventory(stationTypeID, stationID, schoolID) {
    var url, Data;
    url = "../Report/ShowReportTabletMoveByLocation";

    jQuery.ajax({
        type: "POST",
        url: url,
        data: {
            stationTypeID: stationTypeID,
            stationID: stationID,
            schoolID: schoolID
        },
        cache: false,
        success: function (response) {
            //jAlert("error", response.text, "Error Dialog");
        },
        error: function (response) {
            jAlert("error", "ไม่สามารถโหลดรายงานนี้ได้", "ข้อผิดพลาด");
        },
        complete: function (response) {
        }
    });

}

function ShowReportTabletClaims(stationTypeID, stationID, schoolID) {
    var url, Data;
    url = "../Report/ShowReportTabletClaims";

    jQuery.ajax({
        type: "POST",
        url: url,
        data: {
            stationTypeID: stationTypeID,
            stationID: stationID,
            schoolID: schoolID
        },
        cache: false,
        success: function (response) {
            //jAlert("error", response.text, "Error Dialog");
        },
        error: function (response) {
            jAlert("error", "ไม่สามารถโหลดรายงานนี้ได้", "ข้อผิดพลาด");
        },
        complete: function (response) {
        }
    });

}


function ShowReportTabletCheckAllLot() {
    var url, Data;
    url = "../Report/ShowReportTabletCheckAllLot";

    jQuery.ajax({
        type: "POST",
        url: url,
        cache: false,
        success: function (response) {
            //jAlert("error", response.text, "Error Dialog");
        },
        error: function (response) {
            jAlert("error", "ไม่สามารถโหลดรายงานนี้ได้", "ข้อผิดพลาด");
        },
        complete: function (response) {
        }
    });
}


function ShowReportTabletByDistrict() {
    var url, Data;
    url = "../Report/ShowReportTabletByDistrict";

    jQuery.ajax({
        type: "POST",
        url: url,
      //  data: {
      //      prjYear: jQuery("#ddlYear").val(),
      //      PJ02_Status: jQuery("#ddlStatus").val()
      //  },
        cache: false,
        success: function (response) {
            //jAlert("error", response.text, "Error Dialog");
        },
        error: function (response) {
            jAlert("error", "ไม่สามารถโหลดรายงานนี้ได้", "ข้อผิดพลาด");
        },
        complete: function (response) {
        }
    });
}

function ShowReportTabletBySchool() {
    var url, Data;
    url = "../Report/ShowReportTabletBySchool";

    jQuery.ajax({
        type: "POST",
        url: url,
        //  data: {
        //      prjYear: jQuery("#ddlYear").val(),
        //      PJ02_Status: jQuery("#ddlStatus").val()
        //  },
        cache: false,
        success: function (response) {
            //jAlert("error", response.text, "Error Dialog");
        },
        error: function (response) {
            jAlert("error", "ไม่สามารถโหลดรายงานนี้ได้", "ข้อผิดพลาด");
        },
        complete: function (response) {
        }
    });
}

function ShowReportTabletByStudent() {
    var url, Data;
    url = "../Report/ShowReportTabletByStudent";

    jQuery.ajax({
        type: "POST",
        url: url,
        //  data: {
        //      prjYear: jQuery("#ddlYear").val(),
        //      PJ02_Status: jQuery("#ddlStatus").val()
        //  },
        cache: false,
        success: function (response) {
            //jAlert("error", response.text, "Error Dialog");
        },
        error: function (response) {
            jAlert("error", "ไม่สามารถโหลดรายงานนี้ได้", "ข้อผิดพลาด");
        },
        complete: function (response) {
        }
    });
}

function ShowReportTabletByLotCheck() {
    var url, Data;
    url = "../Report/ShowReportTabletByLotCheck";

    jQuery.ajax({
        type: "POST",
        url: url,
        //  data: {
        //      prjYear: jQuery("#ddlYear").val(),
        //      PJ02_Status: jQuery("#ddlStatus").val()
        //  },
        cache: false,
        success: function (response) {
            //jAlert("error", response.text, "Error Dialog");
        },
        error: function (response) {
            jAlert("error", "ไม่สามารถโหลดรายงานนี้ได้", "ข้อผิดพลาด");
        },
        complete: function (response) {
        }
    });
}

function ShowReportTabletByClaim() {
    var url, Data;
    url = "../Report/ShowReportTabletByClaim";

    jQuery.ajax({
        type: "POST",
        url: url,
        //  data: {
        //      prjYear: jQuery("#ddlYear").val(),
        //      PJ02_Status: jQuery("#ddlStatus").val()
        //  },
        cache: false,
        success: function (response) {
            //jAlert("error", response.text, "Error Dialog");
        },
        error: function (response) {
            jAlert("error", "ไม่สามารถโหลดรายงานนี้ได้", "ข้อผิดพลาด");
        },
        complete: function (response) {
        }
    });
}

function ShowReportTabletUserHistory(tabletSerialNumber) {
    var url, Data;
    url = "../Report/ShowReportTabletUserHistory";

    jQuery.ajax({
        type: "POST",
        url: url,
          data: {
              tabletSerialNumber: tabletSerialNumber
          },
        cache: false,
        success: function (response) {
            //jAlert("error", response.text, "Error Dialog");
        },
        error: function (response) {
            jAlert("error", "ไม่สามารถโหลดรายงานนี้ได้", "ข้อผิดพลาด");
        },
        complete: function (response) {
        }
    });
}

function ShowReportUserTabletHistory(userID) {
    var url, Data;
    url = "../Report/ShowReportUserTabletHistory";

    jQuery.ajax({
        type: "POST",
        url: url,
          data: {
              userID: userID
          },
        cache: false,
        success: function (response) {
            //jAlert("error", response.text, "Error Dialog");
        },
        error: function (response) {
            jAlert("error", "ไม่สามารถโหลดรายงานนี้ได้", "ข้อผิดพลาด");
        },
        complete: function (response) {
        }
    });
}


function ShowReportTabletCheckByLot(centralLotID) {
    var url, Data;
    url = "../Report/ShowReportTabletCheckByLot";

    jQuery.ajax({
        type: "POST",
        url: url,
        data: {
            centralLotID: centralLotID
        },
        cache: false,
        success: function (response) {
            //jAlert("error", response.text, "Error Dialog");
        },
        error: function (response) {
            jAlert("error", "ไม่สามารถโหลดรายงานนี้ได้", "ข้อผิดพลาด");
        },
        complete: function (response) {
        }
    });
}
