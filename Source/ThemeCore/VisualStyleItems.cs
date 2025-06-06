namespace ThemeCore
{
    // AEROWIZARDSTYLE class parts and states

    [VisualClass("AddressBand")]
    public enum ADDRESSBANDPARTS
    {
        [VisualStates(typeof(ADDRESSBANDSTATES))]
        ABP_ABBACKGROUND = 1,
    }
    public enum ADDRESSBANDSTATES
    {
        ABBG_NORMAL = 1,
        ABBG_HOT = 2,
        ABBG_DISABLED = 3,
        ABBG_FOCUSED = 4,
    }

    [VisualClass("AEROWIZARD")]
    public enum AEROWIZARDPARTS
    {
        [VisualStates(typeof(TITLEBARSTATES))]
        AW_TITLEBAR = 1,
        [VisualStates(typeof(HEADERAREASTATES))]
        AW_HEADERAREA = 2,
        [VisualStates(typeof(CONTENTAREASTATES))]
        AW_CONTENTAREA = 3,
        AW_COMMANDAREA = 4,
        AW_BUTTON = 5,
    }

    public enum TITLEBARSTATES
    {
        AW_S_TITLEBAR_ACTIVE = 1,
        AW_S_TITLEBAR_INACTIVE = 2,
    }

    public enum HEADERAREASTATES
    {
        AW_S_HEADERAREA_NOMARGIN = 1,
    }

    public enum CONTENTAREASTATES
    {
        AW_S_CONTENTAREA_NOMARGIN = 1,
    }

    // BUTTONSTYLE class parts and states

    [VisualClass("BUTTON")]
    public enum ButtonParts
    {
        [VisualStates(typeof(PUSHBUTTONSTATES))]
        PushButton = 1,
        [VisualStates(typeof(RADIOBUTTONSTATES))]
        RadioButton = 2,
        [VisualStates(typeof(CHECKBOXSTATES))]
        CheckBox = 3,
        [VisualStates(typeof(GROUPBOXSTATES))]
        GroupBox = 4,
        UserButton = 5,
        [VisualStates(typeof(COMMANDLINKSTATES))]
        CommandLink = 6,
        [VisualStates(typeof(COMMANDLINKGLYPHSTATES))]
        CommandLinkGlyph = 7,
        [VisualStates(typeof(RADIOBUTTONSTATES))]
        RadioButtonHcDisabled = 8,
        [VisualStates(typeof(CHECKBOXSTATES))]
        CheckBoxHcDisabled = 9,
        [VisualStates(typeof(GROUPBOXSTATES))]
        GroupBoxHcDisabled = 10,
        [VisualStates(typeof(PUSHBUTTONDROPDOWNSTATES))]
        PushButtonDropDown = 11,
    }

    public enum PUSHBUTTONDROPDOWNSTATES
    {
        PBDDS_NORMAL = 1,
        PBDDS_DISABLED = 2
    };

    public enum PUSHBUTTONSTATES
    {
        PBS_NORMAL = 1,
        PBS_HOT = 2,
        PBS_PRESSED = 3,
        PBS_DISABLED = 4,
        PBS_DEFAULTED = 5,
        PBS_DEFAULTED_ANIMATING = 6,
    }

    public enum RADIOBUTTONSTATES
    {
        RBS_UNCHECKEDNORMAL = 1,
        RBS_UNCHECKEDHOT = 2,
        RBS_UNCHECKEDPRESSED = 3,
        RBS_UNCHECKEDDISABLED = 4,
        RBS_CHECKEDNORMAL = 5,
        RBS_CHECKEDHOT = 6,
        RBS_CHECKEDPRESSED = 7,
        RBS_CHECKEDDISABLED = 8,
    }

    public enum CHECKBOXSTATES
    {
        CBS_UNCHECKEDNORMAL = 1,
        CBS_UNCHECKEDHOT = 2,
        CBS_UNCHECKEDPRESSED = 3,
        CBS_UNCHECKEDDISABLED = 4,
        CBS_CHECKEDNORMAL = 5,
        CBS_CHECKEDHOT = 6,
        CBS_CHECKEDPRESSED = 7,
        CBS_CHECKEDDISABLED = 8,
        CBS_MIXEDNORMAL = 9,
        CBS_MIXEDHOT = 10,
        CBS_MIXEDPRESSED = 11,
        CBS_MIXEDDISABLED = 12,
        CBS_IMPLICITNORMAL = 13,
        CBS_IMPLICITHOT = 14,
        CBS_IMPLICITPRESSED = 15,
        CBS_IMPLICITDISABLED = 16,
        CBS_EXCLUDEDNORMAL = 17,
        CBS_EXCLUDEDHOT = 18,
        CBS_EXCLUDEDPRESSED = 19,
        CBS_EXCLUDEDDISABLED = 20,
    }

    public enum GROUPBOXSTATES
    {
        GBS_NORMAL = 1,
        GBS_DISABLED = 2,
    }

    public enum COMMANDLINKSTATES
    {
        CMDLS_NORMAL = 1,
        CMDLS_HOT = 2,
        CMDLS_PRESSED = 3,
        CMDLS_DISABLED = 4,
        CMDLS_DEFAULTED = 5,
        CMDLS_DEFAULTED_ANIMATING = 6,
    }

    public enum COMMANDLINKGLYPHSTATES
    {
        CMDLGS_NORMAL = 1,
        CMDLGS_HOT = 2,
        CMDLGS_PRESSED = 3,
        CMDLGS_DISABLED = 4,
        CMDLGS_DEFAULTED = 5,
    }

    // COMBOBOXSTYLE class parts and states

    [VisualClass("COMBOBOX")]
    public enum COMBOBOXPARTS
    {
        [VisualStates(typeof(COMBOBOXSTYLESTATES))]
        CP_DROPDOWNBUTTON = 1,
        [VisualStates(typeof(BARBACKGROUNDSTATES))]
        CP_BACKGROUND = 2,
        [VisualStates(typeof(TRANSPARENTBACKGROUNDSTATES))]
        CP_TRANSPARENTBACKGROUND = 3,
        [VisualStates(typeof(BORDERSTATES))]
        CP_BORDER = 4,
        [VisualStates(typeof(READONLYSTATES))]
        CP_READONLY = 5,
        [VisualStates(typeof(DROPDOWNBUTTONRIGHTSTATES))]
        CP_DROPDOWNBUTTONRIGHT = 6,
        [VisualStates(typeof(DROPDOWNBUTTONLEFTSTATES))]
        CP_DROPDOWNBUTTONLEFT = 7,
        [VisualStates(typeof(CUEBANNERSTATES))]
        CP_CUEBANNER = 8,
        [VisualStates(typeof(DROPDOWNITEMSTATES))]
        CP_DROPDOWNITEM = 9,
    }

    public enum COMBOBOXSTYLESTATES
    {
        CBXS_NORMAL = 1,
        CBXS_HOT = 2,
        CBXS_PRESSED = 3,
        CBXS_DISABLED = 4,
    }
    public enum DROPDOWNITEMSTATES
    {
        CBDI_NORMAL = 1,
        CBDI_HIGHLIGHTED = 2,
    };

    public enum DROPDOWNBUTTONRIGHTSTATES
    {
        CBXSR_NORMAL = 1,
        CBXSR_HOT = 2,
        CBXSR_PRESSED = 3,
        CBXSR_DISABLED = 4,
    }

    public enum DROPDOWNBUTTONLEFTSTATES
    {
        CBXSL_NORMAL = 1,
        CBXSL_HOT = 2,
        CBXSL_PRESSED = 3,
        CBXSL_DISABLED = 4,
    }

    public enum TRANSPARENTBACKGROUNDSTATES
    {
        CBTBS_NORMAL = 1,
        CBTBS_HOT = 2,
        CBTBS_DISABLED = 3,
        CBTBS_FOCUSED = 4,
    }

    public enum BORDERSTATES
    {
        CBB_NORMAL = 1,
        CBB_HOT = 2,
        CBB_FOCUSED = 3,
        CBB_DISABLED = 4,
    }

    public enum READONLYSTATES
    {
        CBRO_NORMAL = 1,
        CBRO_HOT = 2,
        CBRO_PRESSED = 3,
        CBRO_DISABLED = 4,
    }

    public enum CUEBANNERSTATES
    {
        CBCB_NORMAL = 1,
        CBCB_HOT = 2,
        CBCB_PRESSED = 3,
        CBCB_DISABLED = 4,
    }

    // COMMUNICATIONSSTYLE class parts and states

    [VisualClass("COMMUNICATIONS")]
    public enum COMMUNICATIONSPARTS
    {
        [VisualStates(typeof(TABSTATES))]
        CSST_TAB = 1,
    }

    public enum TABSTATES
    {
        CSTB_NORMAL = 1,
        CSTB_HOT = 2,
        CSTB_SELECTED = 3,
    }

    // CONTROLPANELSTYLE class parts and states

    [VisualClass("CONTROLPANEL")]
    public enum CONTROLPANELPARTS
    {
        CPANEL_NAVIGATIONPANE = 1,
        CPANEL_CONTENTPANE = 2,
        CPANEL_NAVIGATIONPANELABEL = 3,
        CPANEL_CONTENTPANELABEL = 4,
        CPANEL_TITLE = 5,
        CPANEL_BODYTEXT = 6,
        [VisualStates(typeof(HELPLINKSTATES))]
        CPANEL_HELPLINK = 7,
        [VisualStates(typeof(TASKLINKSTATES))]
        CPANEL_TASKLINK = 8,
        CPANEL_GROUPTEXT = 9,
        [VisualStates(typeof(CONTENTLINKSTATES))]
        CPANEL_CONTENTLINK = 10,
        [VisualStates(typeof(SECTIONTITLELINKSTATES))]
        CPANEL_SECTIONTITLELINK = 11,
        CPANEL_LARGECOMMANDAREA = 12,
        CPANEL_SMALLCOMMANDAREA = 13,
        CPANEL_BUTTON = 14,
        CPANEL_MESSAGETEXT = 15,
        CPANEL_NAVIGATIONPANELINE = 16,
        CPANEL_CONTENTPANELINE = 17,
        CPANEL_BANNERAREA = 18,
        CPANEL_BODYTITLE = 19,
    }

    public enum HELPLINKSTATES
    {
        CPHL_NORMAL = 1,
        CPHL_HOT = 2,
        CPHL_PRESSED = 3,
        CPHL_DISABLED = 4,
    }

    public enum TASKLINKSTATES
    {
        CPTL_NORMAL = 1,
        CPTL_HOT = 2,
        CPTL_PRESSED = 3,
        CPTL_DISABLED = 4,
        CPTL_PAGE = 5,
    }

    public enum CONTENTLINKSTATES
    {
        CPCL_NORMAL = 1,
        CPCL_HOT = 2,
        CPCL_PRESSED = 3,
        CPCL_DISABLED = 4,
    }

    public enum SECTIONTITLELINKSTATES
    {
        CPSTL_NORMAL = 1,
        CPSTL_HOT = 2,
    }

    // DATEPICKERSTYLE class parts and states

    [VisualClass("DATEPICKER")]
    public enum DATEPICKERPARTS
    {
        [VisualStates(typeof(DATETEXTSTATES))]
        DP_DATETEXT = 1,
        [VisualStates(typeof(DATEBORDERSTATES))]
        DP_DATEBORDER = 2,
        [VisualStates(typeof(SHOWCALENDARBUTTONRIGHTSTATES))]
        DP_SHOWCALENDARBUTTONRIGHT = 3,
    }

    public enum DATETEXTSTATES
    {
        DPDT_NORMAL = 1,
        DPDT_DISABLED = 2,
        DPDT_SELECTED = 3,
    }

    public enum DATEBORDERSTATES
    {
        DPDB_NORMAL = 1,
        DPDB_HOT = 2,
        DPDB_FOCUSED = 3,
        DPDB_DISABLED = 4,
    }

    public enum SHOWCALENDARBUTTONRIGHTSTATES
    {
        DPSCBR_NORMAL = 1,
        DPSCBR_HOT = 2,
        DPSCBR_PRESSED = 3,
        DPSCBR_DISABLED = 4,
    }

    // DRAGDROPSTYLE class parts and states

    [VisualClass("DRAGDROP")]
    public enum DRAGDROPPARTS
    {
        [VisualStates(typeof(COPYSTATES))]
        DD_COPY = 1,
        [VisualStates(typeof(MOVESTATES))]
        DD_MOVE = 2,
        [VisualStates(typeof(UPDATEMETADATASTATES))]
        DD_UPDATEMETADATA = 3,
        [VisualStates(typeof(CREATELINKSTATES))]
        DD_CREATELINK = 4,
        [VisualStates(typeof(WARNINGSTATES))]
        DD_WARNING = 5,
        [VisualStates(typeof(NONESTATES))]
        DD_NONE = 6,
        DD_IMAGEBG = 7,
        DD_TEXTBG = 8,
    }

    public enum COPYSTATES
    {
        DDCOPY_HIGHLIGHT = 1,
        DDCOPY_NOHIGHLIGHT = 2,
    }

    public enum MOVESTATES
    {
        DDMOVE_HIGHLIGHT = 1,
        DDMOVE_NOHIGHLIGHT = 2,
    }

    public enum UPDATEMETADATASTATES
    {
        DDUPDATEMETADATA_HIGHLIGHT = 1,
        DDUPDATEMETADATA_NOHIGHLIGHT = 2,
    }

    public enum CREATELINKSTATES
    {
        DDCREATELINK_HIGHLIGHT = 1,
        DDCREATELINK_NOHIGHLIGHT = 2,
    }

    public enum WARNINGSTATES
    {
        DDWARNING_HIGHLIGHT = 1,
        DDWARNING_NOHIGHLIGHT = 2,
    }

    public enum NONESTATES
    {
        DDNONE_HIGHLIGHT = 1,
        DDNONE_NOHIGHLIGHT = 2,
    }

    // EDITSTYLE class parts and states
    // "EDIT"
    [VisualClass("EDIT")]
    [VisualClass("Explorer::Edit")]
    public enum EDITPARTS
    {
        [VisualStates(typeof(EDITTEXTSTATES))]
        EP_EDITTEXT = 1,
        EP_CARET = 2,
        [VisualStates(typeof(BACKGROUNDSTATES))]
        EP_BACKGROUND = 3,
        EP_PASSWORD = 4,
        [VisualStates(typeof(BACKGROUNDWITHBORDERSTATES))]
        EP_BACKGROUNDWITHBORDER = 5,
        [VisualStates(typeof(EDITBORDER_NOSCROLLSTATES))]
        EP_EDITBORDER_NOSCROLL = 6,
        [VisualStates(typeof(EDITBORDER_HSCROLLSTATES))]
        EP_EDITBORDER_HSCROLL = 7,
        [VisualStates(typeof(EDITBORDER_VSCROLLSTATES))]
        EP_EDITBORDER_VSCROLL = 8,
        [VisualStates(typeof(EDITBORDER_HVSCROLLSTATES))]
        EP_EDITBORDER_HVSCROLL = 9,
    }

    public enum EDITTEXTSTATES
    {
        ETS_NORMAL = 1,
        ETS_HOT = 2,
        ETS_SELECTED = 3,
        ETS_DISABLED = 4,
        ETS_FOCUSED = 5,
        ETS_READONLY = 6,
        ETS_ASSIST = 7,
        ETS_CUEBANNER = 8,
    }

    public enum BACKGROUNDSTATES
    {
        EBS_NORMAL = 1,
        EBS_HOT = 2,
        EBS_DISABLED = 3,
        EBS_FOCUSED = 4,
        EBS_READONLY = 5,
        EBS_ASSIST = 6,
    }

    public enum BACKGROUNDWITHBORDERSTATES
    {
        EBWBS_NORMAL = 1,
        EBWBS_HOT = 2,
        EBWBS_DISABLED = 3,
        EBWBS_FOCUSED = 4,
    }

    public enum EDITBORDER_NOSCROLLSTATES
    {
        EPSN_NORMAL = 1,
        EPSN_HOT = 2,
        EPSN_FOCUSED = 3,
        EPSN_DISABLED = 4,
    }

    public enum EDITBORDER_HSCROLLSTATES
    {
        EPSH_NORMAL = 1,
        EPSH_HOT = 2,
        EPSH_FOCUSED = 3,
        EPSH_DISABLED = 4,
    }

    public enum EDITBORDER_VSCROLLSTATES
    {
        EPSV_NORMAL = 1,
        EPSV_HOT = 2,
        EPSV_FOCUSED = 3,
        EPSV_DISABLED = 4,
    }

    public enum EDITBORDER_HVSCROLLSTATES
    {
        EPSHV_NORMAL = 1,
        EPSHV_HOT = 2,
        EPSHV_FOCUSED = 3,
        EPSHV_DISABLED = 4,
    }

    // EXPLORERBARSTYLE class parts and states

    [VisualClass("EXPLORERBAR")]
    public enum EXPLORERBARPARTS
    {
        EBP_HEADERBACKGROUND = 1,
        [VisualStates(typeof(HEADERCLOSESTATES))]
        EBP_HEADERCLOSE = 2,
        [VisualStates(typeof(HEADERPINSTATES))]
        EBP_HEADERPIN = 3,
        [VisualStates(typeof(IEBARMENUSTATES))]
        EBP_IEBARMENU = 4,
        EBP_NORMALGROUPBACKGROUND = 5,
        [VisualStates(typeof(NORMALGROUPCOLLAPSESTATES))]
        EBP_NORMALGROUPCOLLAPSE = 6,
        [VisualStates(typeof(NORMALGROUPEXPANDSTATES))]
        EBP_NORMALGROUPEXPAND = 7,
        EBP_NORMALGROUPHEAD = 8,
        EBP_SPECIALGROUPBACKGROUND = 9,
        [VisualStates(typeof(SPECIALGROUPCOLLAPSESTATES))]
        EBP_SPECIALGROUPCOLLAPSE = 10,
        [VisualStates(typeof(SPECIALGROUPEXPANDSTATES))]
        EBP_SPECIALGROUPEXPAND = 11,
        EBP_SPECIALGROUPHEAD = 12,
    }

    public enum HEADERCLOSESTATES
    {
        EBHC_NORMAL = 1,
        EBHC_HOT = 2,
        EBHC_PRESSED = 3,
    }

    public enum HEADERPINSTATES
    {
        EBHP_NORMAL = 1,
        EBHP_HOT = 2,
        EBHP_PRESSED = 3,
        EBHP_SELECTEDNORMAL = 4,
        EBHP_SELECTEDHOT = 5,
        EBHP_SELECTEDPRESSED = 6,
    }

    public enum IEBARMENUSTATES
    {
        EBM_NORMAL = 1,
        EBM_HOT = 2,
        EBM_PRESSED = 3,
    }

    public enum NORMALGROUPCOLLAPSESTATES
    {
        EBNGC_NORMAL = 1,
        EBNGC_HOT = 2,
        EBNGC_PRESSED = 3,
    }

    public enum NORMALGROUPEXPANDSTATES
    {
        EBNGE_NORMAL = 1,
        EBNGE_HOT = 2,
        EBNGE_PRESSED = 3,
    }

    public enum SPECIALGROUPCOLLAPSESTATES
    {
        EBSGC_NORMAL = 1,
        EBSGC_HOT = 2,
        EBSGC_PRESSED = 3,
    }

    public enum SPECIALGROUPEXPANDSTATES
    {
        EBSGE_NORMAL = 1,
        EBSGE_HOT = 2,
        EBSGE_PRESSED = 3,
    }

    // FLYOUTSTYLE class parts and states

    [VisualClass("FLYOUT")]
    public enum FLYOUTPARTS
    {
        FLYOUT_HEADER = 1,
        [VisualStates(typeof(BODYSTATES))]
        FLYOUT_BODY = 2,
        [VisualStates(typeof(LABELSTATES))]
        FLYOUT_LABEL = 3,
        [VisualStates(typeof(LINKSTATES))]
        FLYOUT_LINK = 4,
        FLYOUT_DIVIDER = 5,
        FLYOUT_WINDOW = 6,
        FLYOUT_LINKAREA = 7,
        [VisualStates(typeof(LINKHEADERSTATES))]
        FLYOUT_LINKHEADER = 8,
    }

    public enum LABELSTATES
    {
        FLS_NORMAL = 1,
        FLS_SELECTED = 2,
        FLS_EMPHASIZED = 3,
        FLS_DISABLED = 4,
    }

    public enum LINKSTATES
    {
        FLYOUTLINK_NORMAL = 1,
        FLYOUTLINK_HOVER = 2,
    }

    public enum BODYSTATES
    {
        FBS_NORMAL = 1,
        FBS_EMPHASIZED = 2,
    }

    public enum LINKHEADERSTATES
    {
        FLH_NORMAL = 1,
        FLH_HOVER = 2,
    }

    // HEADERSTYLE class parts and states

    [VisualClass("HEADER")]
    public enum HEADERPARTS
    {
        [VisualStates(typeof(HEADERITEMSTATES))]
        HP_HEADERITEM = 1,
        [VisualStates(typeof(HEADERITEMLEFTSTATES))]
        HP_HEADERITEMLEFT = 2,
        [VisualStates(typeof(HEADERITEMRIGHTSTATES))]
        HP_HEADERITEMRIGHT = 3,
        [VisualStates(typeof(HEADERSORTARROWSTATES))]
        HP_HEADERSORTARROW = 4,
        [VisualStates(typeof(HEADERDROPDOWNSTATES))]
        HP_HEADERDROPDOWN = 5,
        [VisualStates(typeof(HEADERDROPDOWNFILTERSTATES))]
        HP_HEADERDROPDOWNFILTER = 6,
        [VisualStates(typeof(HEADEROVERFLOWSTATES))]
        HP_HEADEROVERFLOW = 7,
    }

    public enum HEADERSTYLESTATES
    {
        HBG_DETAILS = 1,
        HBG_ICON = 2,
    }

    public enum HEADERITEMSTATES
    {
        HIS_NORMAL = 1,
        HIS_HOT = 2,
        HIS_PRESSED = 3,
        HIS_SORTEDNORMAL = 4,
        HIS_SORTEDHOT = 5,
        HIS_SORTEDPRESSED = 6,
        HIS_ICONNORMAL = 7,
        HIS_ICONHOT = 8,
        HIS_ICONPRESSED = 9,
        HIS_ICONSORTEDNORMAL = 10,
        HIS_ICONSORTEDHOT = 11,
        HIS_ICONSORTEDPRESSED = 12,
    }

    public enum HEADERITEMLEFTSTATES
    {
        HILS_NORMAL = 1,
        HILS_HOT = 2,
        HILS_PRESSED = 3,
    }

    public enum HEADERITEMRIGHTSTATES
    {
        HIRS_NORMAL = 1,
        HIRS_HOT = 2,
        HIRS_PRESSED = 3,
    }

    public enum HEADERSORTARROWSTATES
    {
        HSAS_SORTEDUP = 1,
        HSAS_SORTEDDOWN = 2,
    }

    public enum HEADERDROPDOWNSTATES
    {
        HDDS_NORMAL = 1,
        HDDS_SOFTHOT = 2,
        HDDS_HOT = 3,
    }

    public enum HEADERDROPDOWNFILTERSTATES
    {
        HDDFS_NORMAL = 1,
        HDDFS_SOFTHOT = 2,
        HDDFS_HOT = 3,
    }

    public enum HEADEROVERFLOWSTATES
    {
        HOFS_NORMAL = 1,
        HOFS_HOT = 2,
    }

    // LISTBOXSTYLE class parts and states

    [VisualClass("LISTBOX")]
    public enum LISTBOXPARTS
    {
        [VisualStates(typeof(BORDER_HSCROLLSTATES))]
        LBCP_BORDER_HSCROLL = 1,
        [VisualStates(typeof(BORDER_HVSCROLLSTATES))]
        LBCP_BORDER_HVSCROLL = 2,
        [VisualStates(typeof(BORDER_NOSCROLLSTATES))]
        LBCP_BORDER_NOSCROLL = 3,
        [VisualStates(typeof(BORDER_VSCROLLSTATES))]
        LBCP_BORDER_VSCROLL = 4,
        [VisualStates(typeof(ITEMSTATES))]
        LBCP_ITEM = 5,
    }

    public enum BORDER_HSCROLLSTATES
    {
        LBPSH_NORMAL = 1,
        LBPSH_FOCUSED = 2,
        LBPSH_HOT = 3,
        LBPSH_DISABLED = 4,
    }

    public enum BORDER_HVSCROLLSTATES
    {
        LBPSHV_NORMAL = 1,
        LBPSHV_FOCUSED = 2,
        LBPSHV_HOT = 3,
        LBPSHV_DISABLED = 4,
    }

    public enum BORDER_NOSCROLLSTATES
    {
        LBPSN_NORMAL = 1,
        LBPSN_FOCUSED = 2,
        LBPSN_HOT = 3,
        LBPSN_DISABLED = 4,
    }

    public enum BORDER_VSCROLLSTATES
    {
        LBPSV_NORMAL = 1,
        LBPSV_FOCUSED = 2,
        LBPSV_HOT = 3,
        LBPSV_DISABLED = 4,
    }

    public enum ITEMSTATES
    {
        LBPSI_HOT = 1,
        LBPSI_HOTSELECTED = 2,
        LBPSI_SELECTED = 3,
        LBPSI_SELECTEDNOTFOCUS = 4,
    }

    // LISTVIEWSTYLE class parts and states

    [VisualClass("LISTVIEW")]
    [VisualClass("Desktop::ListView")]
    [VisualClass("Explorer::ListView")]
    public enum LISTVIEWPARTS
    {
        [VisualStates(typeof(LISTITEMSTATES))]
        LVP_LISTITEM = 1,
        LVP_LISTGROUP = 2,
        LVP_LISTDETAIL = 3,
        LVP_LISTSORTEDDETAIL = 4,
        LVP_EMPTYTEXT = 5,
        [VisualStates(typeof(GROUPHEADERSTATES))]
        LVP_GROUPHEADER = 6,
        [VisualStates(typeof(GROUPHEADERLINESTATES))]
        LVP_GROUPHEADERLINE = 7,
        [VisualStates(typeof(EXPANDBUTTONSTATES))]
        LVP_EXPANDBUTTON = 8,
        [VisualStates(typeof(COLLAPSEBUTTONSTATES))]
        LVP_COLLAPSEBUTTON = 9,
        LVP_COLUMNDETAIL = 10,
    }

    public enum LISTITEMSTATES
    {
        LISS_NORMAL = 1,
        LISS_HOT = 2,
        LISS_SELECTED = 3,
        LISS_DISABLED = 4,
        LISS_SELECTEDNOTFOCUS = 5,
        LISS_HOTSELECTED = 6,
    }

    public enum GROUPHEADERSTATES
    {
        LVGH_OPEN = 1,
        LVGH_OPENHOT = 2,
        LVGH_OPENSELECTED = 3,
        LVGH_OPENSELECTEDHOT = 4,
        LVGH_OPENSELECTEDNOTFOCUSED = 5,
        LVGH_OPENSELECTEDNOTFOCUSEDHOT = 6,
        LVGH_OPENMIXEDSELECTION = 7,
        LVGH_OPENMIXEDSELECTIONHOT = 8,
        LVGH_CLOSE = 9,
        LVGH_CLOSEHOT = 10,
        LVGH_CLOSESELECTED = 11,
        LVGH_CLOSESELECTEDHOT = 12,
        LVGH_CLOSESELECTEDNOTFOCUSED = 13,
        LVGH_CLOSESELECTEDNOTFOCUSEDHOT = 14,
        LVGH_CLOSEMIXEDSELECTION = 15,
        LVGH_CLOSEMIXEDSELECTIONHOT = 16,
    }

    public enum GROUPHEADERLINESTATES
    {
        LVGHL_OPEN = 1,
        LVGHL_OPENHOT = 2,
        LVGHL_OPENSELECTED = 3,
        LVGHL_OPENSELECTEDHOT = 4,
        LVGHL_OPENSELECTEDNOTFOCUSED = 5,
        LVGHL_OPENSELECTEDNOTFOCUSEDHOT = 6,
        LVGHL_OPENMIXEDSELECTION = 7,
        LVGHL_OPENMIXEDSELECTIONHOT = 8,
        LVGHL_CLOSE = 9,
        LVGHL_CLOSEHOT = 10,
        LVGHL_CLOSESELECTED = 11,
        LVGHL_CLOSESELECTEDHOT = 12,
        LVGHL_CLOSESELECTEDNOTFOCUSED = 13,
        LVGHL_CLOSESELECTEDNOTFOCUSEDHOT = 14,
        LVGHL_CLOSEMIXEDSELECTION = 15,
        LVGHL_CLOSEMIXEDSELECTIONHOT = 16,
    }

    public enum EXPANDBUTTONSTATES
    {
        LVEB_NORMAL = 1,
        LVEB_HOVER = 2,
        LVEB_PUSHED = 3,
    }

    public enum COLLAPSEBUTTONSTATES
    {
        LVCB_NORMAL = 1,
        LVCB_HOVER = 2,
        LVCB_PUSHED = 3,
    }

    // MENUSTYLE class parts and states

    [VisualClass("MENU")]
    public enum MENUPARTS
    {
        MENU_MENUITEM_TMSCHEMA = 1,
        MENU_MENUDROPDOWN_TMSCHEMA = 2,
        MENU_MENUBARITEM_TMSCHEMA = 3,
        MENU_MENUBARDROPDOWN_TMSCHEMA = 4,
        MENU_CHEVRON_TMSCHEMA = 5,
        MENU_SEPARATOR_TMSCHEMA = 6,
        [VisualStates(typeof(BARBACKGROUNDSTATES))]
        MENU_BARBACKGROUND = 7,
        [VisualStates(typeof(BARITEMSTATES))]
        MENU_BARITEM = 8,
        MENU_POPUPBACKGROUND = 9,
        MENU_POPUPBORDERS = 10,
        [VisualStates(typeof(POPUPCHECKSTATES))]
        MENU_POPUPCHECK = 11,
        [VisualStates(typeof(POPUPCHECKBACKGROUNDSTATES))]
        MENU_POPUPCHECKBACKGROUND = 12,
        MENU_POPUPGUTTER = 13,
        [VisualStates(typeof(POPUPITEMSTATES))]
        MENU_POPUPITEM = 14,
        MENU_POPUPSEPARATOR = 15,
        [VisualStates(typeof(POPUPSUBMENUSTATES))]
        MENU_POPUPSUBMENU = 16,
        [VisualStates(typeof(SYSTEMCLOSESTATES))]
        MENU_SYSTEMCLOSE = 17,
        [VisualStates(typeof(SYSTEMMAXIMIZESTATES))]
        MENU_SYSTEMMAXIMIZE = 18,
        [VisualStates(typeof(SYSTEMMINIMIZESTATES))]
        MENU_SYSTEMMINIMIZE = 19,
        [VisualStates(typeof(SYSTEMRESTORESTATES))]
        MENU_SYSTEMRESTORE = 20,
    }

    public enum BARBACKGROUNDSTATES
    {
        MB_ACTIVE = 1,
        MB_INACTIVE = 2,
    }

    public enum BARITEMSTATES
    {
        MBI_NORMAL = 1,
        MBI_HOT = 2,
        MBI_PUSHED = 3,
        MBI_DISABLED = 4,
        MBI_DISABLEDHOT = 5,
        MBI_DISABLEDPUSHED = 6,
    }

    public enum POPUPCHECKSTATES
    {
        MC_CHECKMARKNORMAL = 1,
        MC_CHECKMARKDISABLED = 2,
        MC_BULLETNORMAL = 3,
        MC_BULLETDISABLED = 4,
    }

    public enum POPUPCHECKBACKGROUNDSTATES
    {
        MCB_DISABLED = 1,
        MCB_NORMAL = 2,
        MCB_BITMAP = 3,
    }

    public enum POPUPITEMSTATES
    {
        MPI_NORMAL = 1,
        MPI_HOT = 2,
        MPI_DISABLED = 3,
        MPI_DISABLEDHOT = 4,
    }

    public enum POPUPSUBMENUSTATES
    {
        MSM_NORMAL = 1,
        MSM_DISABLED = 2,
    }

    public enum SYSTEMCLOSESTATES
    {
        MSYSC_NORMAL = 1,
        MSYSC_DISABLED = 2,
    }

    public enum SYSTEMMAXIMIZESTATES
    {
        MSYSMX_NORMAL = 1,
        MSYSMX_DISABLED = 2,
    }

    public enum SYSTEMMINIMIZESTATES
    {
        MSYSMN_NORMAL = 1,
        MSYSMN_DISABLED = 2,
    }

    public enum SYSTEMRESTORESTATES
    {
        MSYSR_NORMAL = 1,
        MSYSR_DISABLED = 2,
    }

    // NAVIGATION class parts and states

    [VisualClass("NAVIGATION")]
    public enum NAVIGATIONPARTS
    {
        [VisualStates(typeof(NAV_BACKBUTTONSTATES))]
        NAV_BACKBUTTON = 1,
        [VisualStates(typeof(NAV_FORWARDBUTTONSTATES))]
        NAV_FORWARDBUTTON = 2,
        [VisualStates(typeof(NAV_MENUBUTTONSTATES))]
        NAV_MENUBUTTON = 3,
    }

    public enum NAV_BACKBUTTONSTATES
    {
        NAV_BB_NORMAL = 1,
        NAV_BB_HOT = 2,
        NAV_BB_PRESSED = 3,
        NAV_BB_DISABLED = 4,
    }

    public enum NAV_FORWARDBUTTONSTATES
    {
        NAV_FB_NORMAL = 1,
        NAV_FB_HOT = 2,
        NAV_FB_PRESSED = 3,
        NAV_FB_DISABLED = 4,
    }

    public enum NAV_MENUBUTTONSTATES
    {
        NAV_MB_NORMAL = 1,
        NAV_MB_HOT = 2,
        NAV_MB_PRESSED = 3,
        NAV_MB_DISABLED = 4,
    }

    // PROGRESSSTYLE class parts and states

    [VisualClass("PROGRESS")]
    public enum PROGRESSPARTS
    {
        PP_BAR = 1,
        PP_BARVERT = 2,
        PP_CHUNK = 3,
        PP_CHUNKVERT = 4,
        [VisualStates(typeof(FILLSTATES))]
        PP_FILL = 5,
        [VisualStates(typeof(FILLVERTSTATES))]
        PP_FILLVERT = 6,
        PP_PULSEOVERLAY = 7,
        PP_MOVEOVERLAY = 8,
        PP_PULSEOVERLAYVERT = 9,
        PP_MOVEOVERLAYVERT = 10,
        [VisualStates(typeof(TRANSPARENTBARSTATES))]
        PP_TRANSPARENTBAR = 11,
        [VisualStates(typeof(TRANSPARENTBARVERTSTATES))]
        PP_TRANSPARENTBARVERT = 12,
    }

    public enum TRANSPARENTBARSTATES
    {
        PBBS_NORMAL = 1,
        PBBS_PARTIAL = 2,
    }

    public enum TRANSPARENTBARVERTSTATES
    {
        PBBVS_NORMAL = 1,
        PBBVS_PARTIAL = 2,
    }

    public enum FILLSTATES
    {
        PBFS_NORMAL = 1,
        PBFS_ERROR = 2,
        PBFS_PAUSED = 3,
        PBFS_PARTIAL = 4,
    }

    public enum FILLVERTSTATES
    {
        PBFVS_NORMAL = 1,
        PBFVS_ERROR = 2,
        PBFVS_PAUSED = 3,
        PBFVS_PARTIAL = 4,
    }

    // REBARSTYLE class parts and states

    [VisualClass("REBAR")]
    public enum REBARPARTS
    {
        RP_GRIPPER = 1,
        RP_GRIPPERVERT = 2,
        RP_BAND = 3,
        [VisualStates(typeof(CHEVRONSTATES))]
        RP_CHEVRON = 4,
        [VisualStates(typeof(CHEVRONVERTSTATES))]
        RP_CHEVRONVERT = 5,
        RP_BACKGROUND = 6,
        [VisualStates(typeof(SPLITTERSTATES))]
        RP_SPLITTER = 7,
        [VisualStates(typeof(SPLITTERVERTSTATES))]
        RP_SPLITTERVERT = 8,
    }

    public enum CHEVRONSTATES
    {
        CHEVS_NORMAL = 1,
        CHEVS_HOT = 2,
        CHEVS_PRESSED = 3,
    }

    public enum CHEVRONVERTSTATES
    {
        CHEVSV_NORMAL = 1,
        CHEVSV_HOT = 2,
        CHEVSV_PRESSED = 3,
    }

    public enum SPLITTERSTATES
    {
        SPLITS_NORMAL = 1,
        SPLITS_HOT = 2,
        SPLITS_PRESSED = 3,
    }

    public enum SPLITTERVERTSTATES
    {
        SPLITSV_NORMAL = 1,
        SPLITSV_HOT = 2,
        SPLITSV_PRESSED = 3,
    }

    // SCROLLBARSTYLE class parts and states

    [VisualClass("SCROLLBAR")]
    public enum SCROLLBARPARTS
    {
        [VisualStates(typeof(ARROWBTNSTATES))]
        SBP_ARROWBTN = 1,
        [VisualStates(typeof(SCROLLBARSTYLESTATES))]
        SBP_THUMBBTNHORZ = 2,
        [VisualStates(typeof(SCROLLBARSTYLESTATES))]
        SBP_THUMBBTNVERT = 3,
        [VisualStates(typeof(SCROLLBARSTYLESTATES))]
        SBP_LOWERTRACKHORZ = 4,
        [VisualStates(typeof(SCROLLBARSTYLESTATES))]
        SBP_UPPERTRACKHORZ = 5,
        [VisualStates(typeof(SCROLLBARSTYLESTATES))]
        SBP_LOWERTRACKVERT = 6,
        [VisualStates(typeof(SCROLLBARSTYLESTATES))]
        SBP_UPPERTRACKVERT = 7,
        [VisualStates(typeof(SCROLLBARSTYLESTATES))]
        SBP_GRIPPERHORZ = 8,
        [VisualStates(typeof(SCROLLBARSTYLESTATES))]
        SBP_GRIPPERVERT = 9,
        [VisualStates(typeof(SIZEBOXSTATES))]
        SBP_SIZEBOX = 10,
    }

    public enum ARROWBTNSTATES
    {
        ABS_UPNORMAL = 1,
        ABS_UPHOT = 2,
        ABS_UPPRESSED = 3,
        ABS_UPDISABLED = 4,
        ABS_DOWNNORMAL = 5,
        ABS_DOWNHOT = 6,
        ABS_DOWNPRESSED = 7,
        ABS_DOWNDISABLED = 8,
        ABS_LEFTNORMAL = 9,
        ABS_LEFTHOT = 10,
        ABS_LEFTPRESSED = 11,
        ABS_LEFTDISABLED = 12,
        ABS_RIGHTNORMAL = 13,
        ABS_RIGHTHOT = 14,
        ABS_RIGHTPRESSED = 15,
        ABS_RIGHTDISABLED = 16,
        ABS_UPHOVER = 17,
        ABS_DOWNHOVER = 18,
        ABS_LEFTHOVER = 19,
        ABS_RIGHTHOVER = 20,
    }

    public enum SCROLLBARSTYLESTATES
    {
        SCRBS_NORMAL = 1,
        SCRBS_HOT = 2,
        SCRBS_PRESSED = 3,
        SCRBS_DISABLED = 4,
        SCRBS_HOVER = 5,
    }

    public enum SIZEBOXSTATES
    {
        SZB_RIGHTALIGN = 1,
        SZB_LEFTALIGN = 2,
        SZB_TOPRIGHTALIGN = 3,
        SZB_TOPLEFTALIGN = 4,
        SZB_HALFBOTTOMRIGHTALIGN = 5,
        SZB_HALFBOTTOMLEFTALIGN = 6,
        SZB_HALFTOPRIGHTALIGN = 7,
        SZB_HALFTOPLEFTALIGN = 8,
    }

    // SPINSTYLE class parts and states

    [VisualClass("SPIN")]
    public enum SPINPARTS
    {
        [VisualStates(typeof(UPSTATES))]
        SPNP_UP = 1,
        [VisualStates(typeof(DOWNSTATES))]
        SPNP_DOWN = 2,
        [VisualStates(typeof(UPHORZSTATES))]
        SPNP_UPHORZ = 3,
        [VisualStates(typeof(DOWNHORZSTATES))]
        SPNP_DOWNHORZ = 4,
    }

    public enum UPSTATES
    {
        UPS_NORMAL = 1,
        UPS_HOT = 2,
        UPS_PRESSED = 3,
        UPS_DISABLED = 4,
    }

    public enum DOWNSTATES
    {
        DNS_NORMAL = 1,
        DNS_HOT = 2,
        DNS_PRESSED = 3,
        DNS_DISABLED = 4,
    }

    public enum UPHORZSTATES
    {
        UPHZS_NORMAL = 1,
        UPHZS_HOT = 2,
        UPHZS_PRESSED = 3,
        UPHZS_DISABLED = 4,
    }

    public enum DOWNHORZSTATES
    {
        DNHZS_NORMAL = 1,
        DNHZS_HOT = 2,
        DNHZS_PRESSED = 3,
        DNHZS_DISABLED = 4,
    }

    // STATUSSTYLE class parts and states

    [VisualClass("STATUS")]
    public enum STATUSPARTS
    {
        SP_PANE = 1,
        SP_GRIPPERPANE = 2,
        SP_GRIPPER = 3,
    }

    // TABSTYLE class parts and states

    [VisualClass("TAB")]
    public enum TABPARTS
    {
        [VisualStates(typeof(TABITEMSTATES))]
        TABP_TABITEM = 1,
        [VisualStates(typeof(TABITEMLEFTEDGESTATES))]
        TABP_TABITEMLEFTEDGE = 2,
        [VisualStates(typeof(TABITEMRIGHTEDGESTATES))]
        TABP_TABITEMRIGHTEDGE = 3,
        [VisualStates(typeof(TABITEMBOTHEDGESTATES))]
        TABP_TABITEMBOTHEDGE = 4,
        [VisualStates(typeof(TOPTABITEMSTATES))]
        TABP_TOPTABITEM = 5,
        [VisualStates(typeof(TOPTABITEMLEFTEDGESTATES))]
        TABP_TOPTABITEMLEFTEDGE = 6,
        [VisualStates(typeof(TOPTABITEMRIGHTEDGESTATES))]
        TABP_TOPTABITEMRIGHTEDGE = 7,
        [VisualStates(typeof(TOPTABITEMBOTHEDGESTATES))]
        TABP_TOPTABITEMBOTHEDGE = 8,
        TABP_PANE = 9,
        TABP_BODY = 10,
        TABP_AEROWIZARDBODY = 11,
    }

    public enum TABITEMSTATES
    {
        TIS_NORMAL = 1,
        TIS_HOT = 2,
        TIS_SELECTED = 3,
        TIS_DISABLED = 4,
        TIS_FOCUSED = 5,
    }

    public enum TABITEMLEFTEDGESTATES
    {
        TILES_NORMAL = 1,
        TILES_HOT = 2,
        TILES_SELECTED = 3,
        TILES_DISABLED = 4,
        TILES_FOCUSED = 5,
    }

    public enum TABITEMRIGHTEDGESTATES
    {
        TIRES_NORMAL = 1,
        TIRES_HOT = 2,
        TIRES_SELECTED = 3,
        TIRES_DISABLED = 4,
        TIRES_FOCUSED = 5,
    }

    public enum TABITEMBOTHEDGESTATES
    {
        TIBES_NORMAL = 1,
        TIBES_HOT = 2,
        TIBES_SELECTED = 3,
        TIBES_DISABLED = 4,
        TIBES_FOCUSED = 5,
    }

    public enum TOPTABITEMSTATES
    {
        TTIS_NORMAL = 1,
        TTIS_HOT = 2,
        TTIS_SELECTED = 3,
        TTIS_DISABLED = 4,
        TTIS_FOCUSED = 5,
    }

    public enum TOPTABITEMLEFTEDGESTATES
    {
        TTILES_NORMAL = 1,
        TTILES_HOT = 2,
        TTILES_SELECTED = 3,
        TTILES_DISABLED = 4,
        TTILES_FOCUSED = 5,
    }

    public enum TOPTABITEMRIGHTEDGESTATES
    {
        TTIRES_NORMAL = 1,
        TTIRES_HOT = 2,
        TTIRES_SELECTED = 3,
        TTIRES_DISABLED = 4,
        TTIRES_FOCUSED = 5,
    }

    public enum TOPTABITEMBOTHEDGESTATES
    {
        TTIBES_NORMAL = 1,
        TTIBES_HOT = 2,
        TTIBES_SELECTED = 3,
        TTIBES_DISABLED = 4,
        TTIBES_FOCUSED = 5,
    }

    // TASKDIALOGSTYLE class parts and states

    [VisualClass("TASKDIALOG")]
    public enum TASKDIALOGPARTS
    {
        TDLG_PRIMARYPANEL = 1,
        TDLG_MAININSTRUCTIONPANE = 2,
        TDLG_MAINICON = 3,
        [VisualStates(typeof(CONTENTPANESTATES))]
        TDLG_CONTENTPANE = 4,
        TDLG_CONTENTICON = 5,
        TDLG_EXPANDEDCONTENT = 6,
        TDLG_COMMANDLINKPANE = 7,
        TDLG_SECONDARYPANEL = 8,
        TDLG_CONTROLPANE = 9,
        TDLG_BUTTONSECTION = 10,
        TDLG_BUTTONWRAPPER = 11,
        TDLG_EXPANDOTEXT = 12,
        [VisualStates(typeof(EXPANDOBUTTONSTATES))]
        TDLG_EXPANDOBUTTON = 13,
        TDLG_VERIFICATIONTEXT = 14,
        TDLG_FOOTNOTEPANE = 15,
        TDLG_FOOTNOTEAREA = 16,
        TDLG_FOOTNOTESEPARATOR = 17,
        TDLG_EXPANDEDFOOTERAREA = 18,
        TDLG_PROGRESSBAR = 19,
        TDLG_IMAGEALIGNMENT = 20,
        TDLG_RADIOBUTTONPANE = 21,
    }

    public enum CONTENTPANESTATES
    {
        TDLGCPS_STANDALONE = 1,
    }

    public enum EXPANDOBUTTONSTATES
    {
        TDLGEBS_NORMAL = 1,
        TDLGEBS_HOVER = 2,
        TDLGEBS_PRESSED = 3,
        TDLGEBS_EXPANDEDNORMAL = 4,
        TDLGEBS_EXPANDEDHOVER = 5,
        TDLGEBS_EXPANDEDPRESSED = 6,
        TDLGEBS_NORMALDISABLED = 7,
        TDLGEBS_EXPANDEDDISABLED = 8,
    }

    // TEXTSTYLE class parts and states

    public enum TEXTSTYLEPARTS
    {
        TEXT_MAININSTRUCTION = 1,
        TEXT_INSTRUCTION = 2,
        TEXT_BODYTITLE = 3,
        TEXT_BODYTEXT = 4,
        TEXT_SECONDARYTEXT = 5,
        [VisualStates(typeof(HYPERLINKTEXTSTATES))]
        TEXT_HYPERLINKTEXT = 6,
        TEXT_EXPANDED = 7,
        TEXT_LABEL = 8,
        [VisualStates(typeof(CONTROLLABELSTATES))]
        TEXT_CONTROLLABEL = 9,
    }

    public enum HYPERLINKTEXTSTATES
    {
        TS_HYPERLINK_NORMAL = 1,
        TS_HYPERLINK_HOT = 2,
        TS_HYPERLINK_PRESSED = 3,
        TS_HYPERLINK_DISABLED = 4,
    }

    public enum CONTROLLABELSTATES
    {
        TS_CONTROLLABEL_NORMAL = 1,
        TS_CONTROLLABEL_DISABLED = 2,
    }

    // TOOLBARSTYLE class parts and states

    [VisualClass("TOOLBAR")]
    public enum TOOLBARPARTS
    {
        [VisualStates(typeof(TOOLBARSTYLESTATES))]
        TP_BUTTON = 1,
        [VisualStates(typeof(TOOLBARSTYLESTATES))]
        TP_DROPDOWNBUTTON = 2,
        [VisualStates(typeof(TOOLBARSTYLESTATES))]
        TP_SPLITBUTTON = 3,
        [VisualStates(typeof(TOOLBARSTYLESTATES))]
        TP_SPLITBUTTONDROPDOWN = 4,
        [VisualStates(typeof(TOOLBARSTYLESTATES))]
        TP_SEPARATOR = 5,
        [VisualStates(typeof(TOOLBARSTYLESTATES))]
        TP_SEPARATORVERT = 6,
        [VisualStates(typeof(TOOLBARSTYLESTATES))]
        TP_DROPDOWNBUTTONGLYPH = 7,
    }

    public enum TOOLBARSTYLESTATES
    {
        TS_NORMAL = 1,
        TS_HOT = 2,
        TS_PRESSED = 3,
        TS_DISABLED = 4,
        TS_CHECKED = 5,
        TS_HOTCHECKED = 6,
        TS_NEARHOT = 7,
        TS_OTHERSIDEHOT = 8,
    }

    // TOOLTIPSTYLE class parts and states

    [VisualClass("TOOLTIP")]
    public enum TOOLTIPPARTS
    {
        [VisualStates(typeof(STANDARDSTATES))]
        TTP_STANDARD = 1,
        TTP_STANDARDTITLE = 2,
        [VisualStates(typeof(BALLOONSTATES))]
        TTP_BALLOON = 3,
        TTP_BALLOONTITLE = 4,
        [VisualStates(typeof(CLOSESTATES))]
        TTP_CLOSE = 5,
        [VisualStates(typeof(BALLOONSTEMSTATES))]
        TTP_BALLOONSTEM = 6,
        [VisualStates(typeof(WRENCHSTATES))]
        TTP_WRENCH = 7,
    }

    public enum CLOSESTATES
    {
        TTCS_NORMAL = 1,
        TTCS_HOT = 2,
        TTCS_PRESSED = 3,
    }

    public enum STANDARDSTATES
    {
        TTSS_NORMAL = 1,
        TTSS_LINK = 2,
    }

    public enum BALLOONSTATES
    {
        TTBS_NORMAL = 1,
        TTBS_LINK = 2,
    }

    public enum BALLOONSTEMSTATES
    {
        TTBSS_POINTINGUPLEFTWALL = 1,
        TTBSS_POINTINGUPCENTERED = 2,
        TTBSS_POINTINGUPRIGHTWALL = 3,
        TTBSS_POINTINGDOWNRIGHTWALL = 4,
        TTBSS_POINTINGDOWNCENTERED = 5,
        TTBSS_POINTINGDOWNLEFTWALL = 6,
    }

    public enum WRENCHSTATES
    {
        TTWS_NORMAL = 1,
        TTWS_HOT = 2,
        TTWS_PRESSED = 3,
    }

    // TRACKBARSTYLE class parts and states

    [VisualClass("TRACKBAR")]
    public enum TRACKBARPARTS
    {
        [VisualStates(typeof(TRACKSTATES))]
        TKP_TRACK = 1,
        [VisualStates(typeof(TRACKVERTSTATES))]
        TKP_TRACKVERT = 2,
        [VisualStates(typeof(THUMBSTATES))]
        TKP_THUMB = 3,
        [VisualStates(typeof(THUMBBOTTOMSTATES))]
        TKP_THUMBBOTTOM = 4,
        [VisualStates(typeof(THUMBTOPSTATES))]
        TKP_THUMBTOP = 5,
        [VisualStates(typeof(THUMBVERTSTATES))]
        TKP_THUMBVERT = 6,
        [VisualStates(typeof(THUMBLEFTSTATES))]
        TKP_THUMBLEFT = 7,
        [VisualStates(typeof(THUMBRIGHTSTATES))]
        TKP_THUMBRIGHT = 8,
        [VisualStates(typeof(TICSSTATES))]
        TKP_TICS = 9,
        [VisualStates(typeof(TICSVERTSTATES))]
        TKP_TICSVERT = 10,
    }

    public enum TRACKBARSTYLESTATES
    {
        TKS_NORMAL = 1,
    }

    public enum TRACKSTATES
    {
        TRS_NORMAL = 1,
    }

    public enum TRACKVERTSTATES
    {
        TRVS_NORMAL = 1,
    }

    public enum THUMBSTATES
    {
        TUS_NORMAL = 1,
        TUS_HOT = 2,
        TUS_PRESSED = 3,
        TUS_FOCUSED = 4,
        TUS_DISABLED = 5,
    }

    public enum THUMBBOTTOMSTATES
    {
        TUBS_NORMAL = 1,
        TUBS_HOT = 2,
        TUBS_PRESSED = 3,
        TUBS_FOCUSED = 4,
        TUBS_DISABLED = 5,
    }

    public enum THUMBTOPSTATES
    {
        TUTS_NORMAL = 1,
        TUTS_HOT = 2,
        TUTS_PRESSED = 3,
        TUTS_FOCUSED = 4,
        TUTS_DISABLED = 5,
    }

    public enum THUMBVERTSTATES
    {
        TUVS_NORMAL = 1,
        TUVS_HOT = 2,
        TUVS_PRESSED = 3,
        TUVS_FOCUSED = 4,
        TUVS_DISABLED = 5,
    }

    public enum THUMBLEFTSTATES
    {
        TUVLS_NORMAL = 1,
        TUVLS_HOT = 2,
        TUVLS_PRESSED = 3,
        TUVLS_FOCUSED = 4,
        TUVLS_DISABLED = 5,
    }

    public enum THUMBRIGHTSTATES
    {
        TUVRS_NORMAL = 1,
        TUVRS_HOT = 2,
        TUVRS_PRESSED = 3,
        TUVRS_FOCUSED = 4,
        TUVRS_DISABLED = 5,
    }

    public enum TICSSTATES
    {
        TSS_NORMAL = 1,
    }

    public enum TICSVERTSTATES
    {
        TSVS_NORMAL = 1,
    }

    // TREEVIEWSTYLE class parts and states

    [VisualClass("TREEVIEW")]
    [VisualClass("Explorer::TreeView")]
    public enum TREEVIEWPARTS
    {
        [VisualStates(typeof(TREEITEMSTATES))]
        TVP_TREEITEM = 1,
        [VisualStates(typeof(GLYPHSTATES))]
        TVP_GLYPH = 2,
        TVP_BRANCH = 3,
        [VisualStates(typeof(HOTGLYPHSTATES))]
        TVP_HOTGLYPH = 4,
    }

    public enum TREEITEMSTATES
    {
        TREIS_NORMAL = 1,
        TREIS_HOT = 2,
        TREIS_SELECTED = 3,
        TREIS_DISABLED = 4,
        TREIS_SELECTEDNOTFOCUS = 5,
        TREIS_HOTSELECTED = 6,
    }

    public enum GLYPHSTATES
    {
        GLPS_CLOSED = 1,
        GLPS_OPENED = 2,
    }

    public enum HOTGLYPHSTATES
    {
        HGLPS_CLOSED = 1,
        HGLPS_OPENED = 2,
    }

    // USERTILE class parts and states

    [VisualClass("USERTILE")]
    public enum USERTILEPARTS
    {
        UTP_STROKEBACKGROUND = 1,
        [VisualStates(typeof(HOVERBACKGROUNDSTATES))]
        UTP_HOVERBACKGROUND = 2,
    }

    public enum HOVERBACKGROUNDSTATES
    {
        UTS_NORMAL = 1,
        UTS_HOT = 2,
        UTS_PRESSED = 3,
    }

    // TEXTSELECTIONGRIPPER class parts and states

    [VisualClass("TEXTSELECTIONGRIPPER")]
    public enum TEXTSELECTIONGRIPPERPARTS
    {
        [VisualStates(typeof(GRIPPERSTATES))]
        TSGP_GRIPPER = 1,
    }

    public enum GRIPPERSTATES
    {
        TSGS_NORMAL = 1,
        TSGS_CENTERED = 2,
    }

    // WINDOWSTYLE class parts and states

    [VisualClass("WINDOW")]
    public enum WINDOWPARTS
    {
        [VisualStates(typeof(CAPTIONSTATES))]
        WP_CAPTION = 1,
        [VisualStates(typeof(SMALLCAPTIONSTATES))]
        WP_SMALLCAPTION = 2,
        [VisualStates(typeof(MINCAPTIONSTATES))]
        WP_MINCAPTION = 3,
        [VisualStates(typeof(SMALLCAPTIONSTATES))]
        WP_SMALLMINCAPTION = 4,
        [VisualStates(typeof(MAXCAPTIONSTATES))]
        WP_MAXCAPTION = 5,
        [VisualStates(typeof(SMALLCAPTIONSTATES))]
        WP_SMALLMAXCAPTION = 6,
        [VisualStates(typeof(FRAMELEFTSTATES))]
        WP_FRAMELEFT = 7,
        [VisualStates(typeof(FRAMERIGHTSTATES))]
        WP_FRAMERIGHT = 8,
        [VisualStates(typeof(FRAMEBOTTOMSTATES))]
        WP_FRAMEBOTTOM = 9,
        [VisualStates(typeof(SMALLFRAMELEFTSTATES))]
        WP_SMALLFRAMELEFT = 10,
        [VisualStates(typeof(SMALLFRAMERIGHTSTATES))]
        WP_SMALLFRAMERIGHT = 11,
        [VisualStates(typeof(SMALLFRAMEBOTTOMSTATES))]
        WP_SMALLFRAMEBOTTOM = 12,
        [VisualStates(typeof(SYSBUTTONSTATES))]
        WP_SYSBUTTON = 13,
        [VisualStates(typeof(SYSBUTTONSTATES))]
        WP_MDISYSBUTTON = 14,
        [VisualStates(typeof(MINBUTTONSTATES))]
        WP_MINBUTTON = 15,
        [VisualStates(typeof(MDIMINBUTTONSTATES))]
        WP_MDIMINBUTTON = 16,
        [VisualStates(typeof(MAXBUTTONSTATES))]
        WP_MAXBUTTON = 17,
        [VisualStates(typeof(CLOSEBUTTONSTATES))]
        WP_CLOSEBUTTON = 18,
        [VisualStates(typeof(SMALLCLOSEBUTTONSTATES))]
        WP_SMALLCLOSEBUTTON = 19,
        [VisualStates(typeof(MDICLOSEBUTTONSTATES))]
        WP_MDICLOSEBUTTON = 20,
        [VisualStates(typeof(RESTOREBUTTONSTATES))]
        WP_RESTOREBUTTON = 21,
        [VisualStates(typeof(MDIRESTOREBUTTONSTATES))]
        WP_MDIRESTOREBUTTON = 22,
        [VisualStates(typeof(HELPBUTTONSTATES))]
        WP_HELPBUTTON = 23,
        [VisualStates(typeof(HELPBUTTONSTATES))]
        WP_MDIHELPBUTTON = 24,
        [VisualStates(typeof(HORZSCROLLSTATES))]
        WP_HORZSCROLL = 25,
        [VisualStates(typeof(HORZTHUMBSTATES))]
        WP_HORZTHUMB = 26,
        [VisualStates(typeof(VERTSCROLLSTATES))]
        WP_VERTSCROLL = 27,
        [VisualStates(typeof(VERTTHUMBSTATES))]
        WP_VERTTHUMB = 28,
        WP_DIALOG = 29,
        WP_CAPTIONSIZINGTEMPLATE = 30,
        WP_SMALLCAPTIONSIZINGTEMPLATE = 31,
        WP_FRAMELEFTSIZINGTEMPLATE = 32,
        WP_SMALLFRAMELEFTSIZINGTEMPLATE = 33,
        WP_FRAMERIGHTSIZINGTEMPLATE = 34,
        WP_SMALLFRAMERIGHTSIZINGTEMPLATE = 35,
        WP_FRAMEBOTTOMSIZINGTEMPLATE = 36,
        WP_SMALLFRAMEBOTTOMSIZINGTEMPLATE = 37,
        [VisualStates(typeof(FRAMESTATES))]
        WP_FRAME = 38,
        [VisualStates(typeof(BORDERSTATES))]
        WP_BORDER = 39,
    }

    public enum FRAMESTATES
    {
        FS_ACTIVE = 1,
        FS_INACTIVE = 2,
    }

    public enum CAPTIONSTATES
    {
        CS_ACTIVE = 1,
        CS_INACTIVE = 2,
        CS_DISABLED = 3,
    }

    public enum MAXCAPTIONSTATES
    {
        MXCS_ACTIVE = 1,
        MXCS_INACTIVE = 2,
        MXCS_DISABLED = 3,
    }

    public enum MINCAPTIONSTATES
    {
        MNCS_ACTIVE = 1,
        MNCS_INACTIVE = 2,
        MNCS_DISABLED = 3,
    }

    public enum HORZSCROLLSTATES
    {
        HSS_NORMAL = 1,
        HSS_HOT = 2,
        HSS_PUSHED = 3,
        HSS_DISABLED = 4,
    }

    public enum HORZTHUMBSTATES
    {
        HTS_NORMAL = 1,
        HTS_HOT = 2,
        HTS_PUSHED = 3,
        HTS_DISABLED = 4,
    }

    public enum VERTSCROLLSTATES
    {
        VSS_NORMAL = 1,
        VSS_HOT = 2,
        VSS_PUSHED = 3,
        VSS_DISABLED = 4,
    }

    public enum VERTTHUMBSTATES
    {
        VTS_NORMAL = 1,
        VTS_HOT = 2,
        VTS_PUSHED = 3,
        VTS_DISABLED = 4,
    }

    public enum SYSBUTTONSTATES
    {
        SBS_NORMAL = 1,
        SBS_HOT = 2,
        SBS_PUSHED = 3,
        SBS_DISABLED = 4,
    }

    public enum MINBUTTONSTATES
    {
        MINBS_NORMAL = 1,
        MINBS_HOT = 2,
        MINBS_PUSHED = 3,
        MINBS_DISABLED = 4,
    }

    public enum MAXBUTTONSTATES
    {
        MAXBS_NORMAL = 1,
        MAXBS_HOT = 2,
        MAXBS_PUSHED = 3,
        MAXBS_DISABLED = 4,
    }

    public enum RESTOREBUTTONSTATES
    {
        RBS_NORMAL = 1,
        RBS_HOT = 2,
        RBS_PUSHED = 3,
        RBS_DISABLED = 4,
    }

    public enum HELPBUTTONSTATES
    {
        HBS_NORMAL = 1,
        HBS_HOT = 2,
        HBS_PUSHED = 3,
        HBS_DISABLED = 4,
    }

    public enum CLOSEBUTTONSTATES
    {
        CBS_NORMAL = 1,
        CBS_HOT = 2,
        CBS_PUSHED = 3,
        CBS_DISABLED = 4,
    }

    public enum SMALLCLOSEBUTTONSTATES
    {
        SCBS_NORMAL = 1,
        SCBS_HOT = 2,
        SCBS_PUSHED = 3,
        SCBS_DISABLED = 4,
    }

    public enum FRAMEBOTTOMSTATES
    {
        FRB_ACTIVE = 1,
        FRB_INACTIVE = 2,
    }

    public enum FRAMELEFTSTATES
    {
        FRL_ACTIVE = 1,
        FRL_INACTIVE = 2,
    }

    public enum FRAMERIGHTSTATES
    {
        FRR_ACTIVE = 1,
        FRR_INACTIVE = 2,
    }

    public enum SMALLCAPTIONSTATES
    {
        SCS_ACTIVE = 1,
        SCS_INACTIVE = 2,
        SCS_DISABLED = 3,
    }

    public enum SMALLFRAMEBOTTOMSTATES
    {
        SFRB_ACTIVE = 1,
        SFRB_INACTIVE = 2,
    }

    public enum SMALLFRAMELEFTSTATES
    {
        SFRL_ACTIVE = 1,
        SFRL_INACTIVE = 2,
    }

    public enum SMALLFRAMERIGHTSTATES
    {
        SFRR_ACTIVE = 1,
        SFRR_INACTIVE = 2,
    }

    public enum MDICLOSEBUTTONSTATES
    {
        MDCL_NORMAL = 1,
        MDCL_HOT = 2,
        MDCL_PUSHED = 3,
        MDCL_DISABLED = 4,
    }

    public enum MDIMINBUTTONSTATES
    {
        MDMI_NORMAL = 1,
        MDMI_HOT = 2,
        MDMI_PUSHED = 3,
        MDMI_DISABLED = 4,
    }

    public enum MDIRESTOREBUTTONSTATES
    {
        MDRE_NORMAL = 1,
        MDRE_HOT = 2,
        MDRE_PUSHED = 3,
        MDRE_DISABLED = 4,
    }

    // LINK class parts and states

    [VisualClass("LINK")]
    public enum LINKPARTS
    {
        [VisualStates(typeof(HYPERLINKSTATES))]
        LP_HYPERLINK = 1,
    }

    public enum HYPERLINKSTATES
    {
        HLS_NORMALTEXT = 1,
        HLS_LINKTEXT = 2,
    }

    // EMPTYMARKUP class parts and states

    [VisualClass("EMPTYMARKUP")]
    public enum EMPTYMARKUPPARTS
    {
        [VisualStates(typeof(MARKUPTEXTSTATES))]
        EMP_MARKUPTEXT = 1,
    }

    public enum MARKUPTEXTSTATES
    {
        EMT_NORMALTEXT = 1,
        EMT_LINKTEXT = 2,
    }

    // STATIC class parts and states

    [VisualClass("STATIC")]
    public enum STATICPARTS
    {
        STAT_TEXT = 1,
    }

    // PAGE class parts and states

    [VisualClass("PAGE")]
    public enum PAGEPARTS
    {
        PGRP_UP = 1,
        PGRP_DOWN = 2,
        PGRP_UPHORZ = 3,
        PGRP_DOWNHORZ = 4,
    }

    // MONTHCAL class parts and states

    [VisualClass("MONTHCAL")]
    public enum MONTHCALPARTS
    {
        MC_BACKGROUND = 1,
        MC_BORDERS = 2,
        MC_GRIDBACKGROUND = 3,
        MC_COLHEADERSPLITTER = 4,
        [VisualStates(typeof(GRIDCELLBACKGROUNDSTATES))]
        MC_GRIDCELLBACKGROUND = 5,
        [VisualStates(typeof(GRIDCELLSTATES))]
        MC_GRIDCELL = 6,
        [VisualStates(typeof(GRIDCELLUPPERSTATES))]
        MC_GRIDCELLUPPER = 7,
        [VisualStates(typeof(TRAILINGGRIDCELLSTATES))]
        MC_TRAILINGGRIDCELL = 8,
        [VisualStates(typeof(TRAILINGGRIDCELLUPPERSTATES))]
        MC_TRAILINGGRIDCELLUPPER = 9,
        [VisualStates(typeof(NAVNEXTSTATES))]
        MC_NAVNEXT = 10,
        [VisualStates(typeof(NAVPREVSTATES))]
        MC_NAVPREV = 11,
    }

    public enum GRIDCELLBACKGROUNDSTATES
    {
        MCGCB_SELECTED = 1,
        MCGCB_HOT = 2,
        MCGCB_SELECTEDHOT = 3,
        MCGCB_SELECTEDNOTFOCUSED = 4,
        MCGCB_TODAY = 5,
        MCGCB_TODAYSELECTED = 6,
    }

    public enum GRIDCELLSTATES
    {
        MCGC_HOT = 1,
        MCGC_HASSTATE = 2,
        MCGC_HASSTATEHOT = 3,
        MCGC_TODAY = 4,
        MCGC_TODAYSELECTED = 5,
        MCGC_SELECTED = 6,
        MCGC_SELECTEDHOT = 7,
    }

    public enum GRIDCELLUPPERSTATES
    {
        MCGCU_HOT = 1,
        MCGCU_HASSTATE = 2,
        MCGCU_HASSTATEHOT = 3,
        MCGCU_SELECTED = 4,
        MCGCU_SELECTEDHOT = 5,
    }

    public enum TRAILINGGRIDCELLSTATES
    {
        MCTGC_HOT = 1,
        MCTGC_HASSTATE = 2,
        MCTGC_HASSTATEHOT = 3,
        MCTGC_TODAY = 4,
        MCTGC_TODAYSELECTED = 5,
        MCTGC_SELECTED = 6,
        MCTGC_SELECTEDHOT = 7,
    }

    public enum TRAILINGGRIDCELLUPPERSTATES
    {
        MCTGCU_HOT = 1,
        MCTGCU_HASSTATE = 2,
        MCTGCU_HASSTATEHOT = 3,
        MCTGCU_SELECTED = 4,
        MCTGCU_SELECTEDHOT = 5,
    }

    public enum NAVNEXTSTATES
    {
        MCNN_NORMAL = 1,
        MCNN_HOT = 2,
        MCNN_PRESSED = 3,
        MCNN_DISABLED = 4,
    }

    public enum NAVPREVSTATES
    {
        MCNP_NORMAL = 1,
        MCNP_HOT = 2,
        MCNP_PRESSED = 3,
        MCNP_DISABLED = 4,
    }

    // CLOCK class parts and states

    [VisualClass("CLOCK")]
    public enum CLOCKPARTS
    {
        [VisualStates(typeof(CLOCKSTATES))]
        CLP_TIME = 1,
    }

    public enum CLOCKSTATES
    {
        CLS_NORMAL = 1,
        CLS_HOT = 2,
        CLS_PRESSED = 3,
    }

    // TRAYNOTIFY class parts and states

    [VisualClass("TRAYNOTIFY")]
    public enum TRAYNOTIFYPARTS
    {
        TNP_BACKGROUND = 1,
        TNP_ANIMBACKGROUND = 2,
    }

    // TASKBAR class parts and states

    [VisualClass("TASKBAR")]
    public enum TASKBARPARTS
    {
        TBP_BACKGROUNDBOTTOM = 1,
        TBP_BACKGROUNDRIGHT = 2,
        TBP_BACKGROUNDTOP = 3,
        TBP_BACKGROUNDLEFT = 4,
        TBP_SIZINGBARBOTTOM = 5,
        TBP_SIZINGBARRIGHT = 6,
        TBP_SIZINGBARTOP = 7,
        TBP_SIZINGBARLEFT = 8,
    }

    // TASKBAND class parts and states

    [VisualClass("TASKBAND")]
    public enum TASKBANDPARTS
    {
        TDP_GROUPCOUNT = 1,
        TDP_FLASHBUTTON = 2,
        TDP_FLASHBUTTONGROUPMENU = 3,
    }

    // STARTPANEL class parts and states

    [VisualClass("STARTPANEL")]
    public enum STARTPANELPARTS
    {
        SPP_USERPANE = 1,
        SPP_MOREPROGRAMS = 2,
        [VisualStates(typeof(MOREPROGRAMSARROWSTATES))]
        SPP_MOREPROGRAMSARROW = 3,
        SPP_PROGLIST = 4,
        SPP_PROGLISTSEPARATOR = 5,
        SPP_PLACESLIST = 6,
        SPP_PLACESLISTSEPARATOR = 7,
        SPP_LOGOFF = 8,
        [VisualStates(typeof(LOGOFFBUTTONSSTATES))]
        SPP_LOGOFFBUTTONS = 9,
        SPP_USERPICTURE = 10,
        SPP_PREVIEW = 11,
        [VisualStates(typeof(MOREPROGRAMSTABSTATES))]
        SPP_MOREPROGRAMSTAB = 12,
        SPP_NSCHOST = 13,
        [VisualStates(typeof(SOFTWAREEXPLORERSTATES))]
        SPP_SOFTWAREEXPLORER = 14,
        [VisualStates(typeof(OPENBOXSTATES))]
        SPP_OPENBOX = 15,
        SPP_SEARCHVIEW = 16,
        [VisualStates(typeof(MOREPROGRAMSARROWBACKSTATES))]
        SPP_MOREPROGRAMSARROWBACK = 17,
        SPP_TOPMATCH = 18,
        SPP_LOGOFFSPLITBUTTONDROPDOWN = 19,
    }

    public enum MOREPROGRAMSTABSTATES
    {
        SPMPT_NORMAL = 1,
        SPMPT_HOT = 2,
        SPMPT_SELECTED = 3,
        SPMPT_DISABLED = 4,
        SPMPT_FOCUSED = 5,
    }

    public enum SOFTWAREEXPLORERSTATES
    {
        SPSE_NORMAL = 1,
        SPSE_HOT = 2,
        SPSE_SELECTED = 3,
        SPSE_DISABLED = 4,
        SPSE_FOCUSED = 5,
    }

    public enum OPENBOXSTATES
    {
        SPOB_NORMAL = 1,
        SPOB_HOT = 2,
        SPOB_SELECTED = 3,
        SPOB_DISABLED = 4,
        SPOB_FOCUSED = 5,
    }

    public enum MOREPROGRAMSARROWSTATES
    {
        SPS_NORMAL = 1,
        SPS_HOT = 2,
        SPS_PRESSED = 3,
    }

    public enum MOREPROGRAMSARROWBACKSTATES
    {
        SPSB_NORMAL = 1,
        SPSB_HOT = 2,
        SPSB_PRESSED = 3,
    }

    public enum LOGOFFBUTTONSSTATES
    {
        SPLS_NORMAL = 1,
        SPLS_HOT = 2,
        SPLS_PRESSED = 3,
    }

    // MENUBAND class parts and states

    [VisualClass("MENUBAND")]
    public enum MENUBANDPARTS
    {
        MDP_NEWAPPBUTTON = 1,
        MDP_SEPERATOR = 2,
    }

    public enum MENUBANDSTATES
    {
        MDS_NORMAL = 1,
        MDS_HOT = 2,
        MDS_PRESSED = 3,
        MDS_DISABLED = 4,
        MDS_CHECKED = 5,
        MDS_HOTCHECKED = 6,
    }
}
