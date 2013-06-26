﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using Golem.Framework;
using OpenQA.Selenium;


namespace Golem.PageObjects.Emcon.FMX
{
    public class FMX_JobsTab : FmxMenuBar
    {
        //Above Menu Bar Objects
        Element btn_JobSearch = new Element("JobSearchButton", By.Id("ctl00_ContentPlaceHolder2_btnSearch"));

        //job sub-tabs
        Element tab_Job_Closing = new Element("JobClosingTab", By.Id("ctl00_ContentPlaceHolder1_ucJobMenu_lnkClosing"));
        Element tab_Job_Pricing = new Element("JobPricingTab", By.Id("ctl00_ContentPlaceHolder1_ucJobMenu_lnkPricing"));
        Element tab_Pending_Jobs = new Element("PendingJobsTab", By.Id("ctl00_ContentPlaceHolder1_ucJobMenu_lnkPending"));
        Element tab_RTV_Deficiencies = new Element("RTVDeficienciesTab", By.Id("ctl00_ContentPlaceHolder1_ucJobMenu_lnkRTV"));
        Element tab_Job_JobRequests = new Element("JobRequestsTab", By.Id("ctl00_ContentPlaceHolder1_ucJobMenu_lnkJobs"));

<<<<<<< HEAD
        //job Requests Sub-tab
        Element table_JobRequests_CustomerName = new Element("JobRequestsTable", By.XPath("//table[@id='ctl00_ContentPlaceHolder1_fvRequest']/tbody/tr/td/table/tbody/tr[4]/td[2]"));
        Element btn_JobRequests_Request = new Element("RequestButton", By.Id("ctl00_ContentPlaceHolder1_lnkbRequestRequest"));
        Element btn_JobRequests_Location = new Element("LocationButton", By.Id("ctl00_ContentPlaceHolder1_lnkbRequestLocation"));
        Element txt_RequestNumber = new Element("txt_RequestNumber", By.XPath("//table[@id='ctl00_ContentPlaceHolder1_fvRequest']/tbody/tr/td/table/tbody/tr[2]/td[2]"));
        //New Job-Request Specific
        Element btn_JobRequests_CustomerSearch = new Element("CustomerSearchButton", By.Id("ctl00_ContentPlaceHolder1_fvRequest_lbPopSearchCust"));
        Element dd_BusinessType = new Element("dd_BuisnessType", By.Id("ctl00_ContentPlaceHolder1_fvRequest_ddlBusinessType"));
        Element dd_Team = new Element("dd_Team", By.Id("ctl00_ContentPlaceHolder1_fvRequest_ddlTeam"));
        Element dd_RequestSource = new Element("dd_RequestSource", By.Id("ctl00_ContentPlaceHolder1_fvRequest_ddlRequestSource"));  //has a default value
        Element txt_RequesterName = new Element("txt_RequesterName", By.Id("ctl00_ContentPlaceHolder1_fvRequest_txtRequesterName"));
        Element txt_RequesterTitle = new Element("txt_RequesterTitle", By.Id("ctl00_ContentPlaceHolder1_fvRequest_txtRequesterTitle"));
        Element txt_RequestDescription = new Element("txt_RequestDescription", By.Id("ctl00_ContentPlaceHolder1_fvRequest_txtRequestDescription"));
        Element btn_SaveJobRequest = new Element("btn_SaveJobRequest", By.Id("ctl00_ContentPlaceHolder1_fvRequest_lbtnInsertRequest1"));

        Element btn_RTVIssues = new Element("btn_RTVIssues", By.Id("ctl00_ContentPlaceHolder2_lbtnRTV"));


        //New Location
        Element btn_AddNewLocation = new Element("AddNewLocationButton", By.Id("ctl00_ContentPlaceHolder1_fvLocation_lbtnNewLocation"));
        Element btn_SaveLocation = new Element("SaveLocationButton", By.Id("ctl00_ContentPlaceHolder1_fvLocation_lbtnInsertLocation2"));

        //new

        //Dynamic Search PopUp
        Element pop_DynamicSearch = new Element("DynamicSearch_JobSearch_Popup", By.Id("ctl00_ContentPlaceHolder1_pnlPopUpSearch"));
        Element txt_CustomerName_DynamicSearch_Pop = new Element("CustomerNameSearchField", By.Id("ctl00_ContentPlaceHolder1_ucDynamicSearch_rpSearchForm_ctl01_txtTextBoxStr"));
        Element btn_SearchButton = new Element("DyanicSearchButton", By.Id("ctl00_ContentPlaceHolder1_ucDynamicSearch_btnSearch1"));
        Element table_SearchResultsTable = new Element("DynamicSearchResultsTable", By.XPath("//table[@id='ctl00_ContentPlaceHolder1_ucDynamicSearch_ucCustomerSearchResultsGrid_gvGrid']/tbody/tr[3]/td[2]"));
        Element btn_PopupClose = new Element("PopupCloseButton", By.Id("ctl00_ContentPlaceHolder1_LinkButton1"));

        //Customer Search Popup
        Element pop_CustomerSearch = new Element("CustomerSearch_Popup", By.Id("ctl00_ContentPlaceHolder1_pnlPopUpCust"));
        Element txt_CustomerName_CustomerSearch_pop = new Element("txt_CustomerSearchName_Pop", By.Id("ctl00_ContentPlaceHolder1_ucCustomerParentSearch_rpSearchForm_ctl01_txtTextBoxStr"));
        Element btn_CustomerSearch = new Element("CustomerSearchButton", By.Id("ctl00_ContentPlaceHolder1_ucCustomerParentSearch_btnSearch1"));
        Element table_CustomerSearchResults_grid = new Element("Table_CustomerSearchResultsgrid", By.XPath("//table[@id='ctl00_ContentPlaceHolder1_ucCustomerParentSearch_ucCustomerSearchResultsGrid_gvGrid']/tbody/tr[2]/td[2]"));

        //this should be set by the search field
        private static string CustomerName;
        
        public FMX_JobsTab SearchJobs()
=======
        public FMX_Jobs_JobRequests SearchJobs()
>>>>>>> 735b3e89bc7db84ab131d32d6ac13bdb8b3dcd5d
        {
            btn_JobSearch.VerifyVisible(5);
            btn_JobSearch.Click();
            return new FMX_Jobs_JobRequests();
        }
        

        public FMX_JobsTab JobRequestsSubTab()
        {
            tab_Job_JobRequests.Click();
            return new FMX_Jobs_JobRequests();
        }

        public FMX_Jobs_JobClosing ClickJobClosingTab()
        {
            tab_Job_Closing.Click();
            return new FMX_Jobs_JobClosing();
        }

        public FMX_Jobs_JobPricing ClickJobPricingTab()
        {
            tab_Job_Pricing.Click();
            return new FMX_Jobs_JobPricing();
        }


        public FMX_JobsTab ClickJobWithCompletedStatus()
        {
            driver.FindElementWithText("Completed").Click();
            return new FMX_JobsTab();
        }

        public FMX_Jobs_RTVIssues ClickRTVIssuesButton()
        {
            btn_RTVIssues.Click();
            return new FMX_Jobs_RTVIssues();
        }

        
        public override void WaitForElements()
        {
            base.WaitForElements();
            tab_Job_JobRequests.VerifyVisible(5);
        }

       

    }
}

