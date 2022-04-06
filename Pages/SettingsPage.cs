using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_Instagram_Selenium.Pages
{
    class SettingsPage
    {
       // public static IWebDriver driver = null;
        private readonly IWebDriver _driver;

        private By ChangePasswordXpath => By.XPath("//a[contains(text(),'Change Password')]");
        private By PasswordAssertionXpath => By.XPath("//h1[contains(text(),'sqa.qups')]");
        private By OldPasswordXpath => By.XPath("//input[@id='cppOldPassword']");
        private By NewPasswordXpath => By.XPath("//input[@id='cppNewPassword']");
        private By CnfrmNewPasswordXpath => By.XPath("//input[@id='cppConfirmPassword']");
        private By ChangePasswordButtonXpath => By.XPath("//button[contains(text(),'Change Password')]");
        private By AppsAndWebsiteXpath => By.XPath("//a[contains(text(),'Apps and Websites')]");
        private By ActiveXpath => By.XPath("//span[contains(text(),'Active')]");
        private By ExpiredXpath => By.XPath("//span[contains(text(),'Expired')]");
        private By RemovedXpath => By.XPath("//span[contains(text(),'Removed')]");
        private By EmailAndSmsXpath => By.XPath("//a[contains(text(),'Email and SMS')]");
        private By FeedBackEmailXpath => By.XPath("//*[@id='react-root']/section/main/div/article/div/div[2]/label/div");
        private By ReminderEmailXpath => By.XPath("//*[@id='react-root']/section/main/div/article/div/div[3]/label/div");
        private By ProductEmailXpath => By.XPath("//*[@id='react-root']/section/main/div/article/div/div[4]/label/div");
        private By NewsEmailXpath => By.XPath("//*[@id='react-root']/section/main/div/article/div/div[5]/label/div");
        private By PushNotificationXpath => By.XPath("//a[contains(text(),'Push Notifications')]");
        private By LikesXpath => By.XPath("//*[@id='igCoreRadioButtonlikes3']");
        private By CommentsXpath => By.XPath("//*[@id='igCoreRadioButtoncomments3']");
        private By CommentLikeXpath => By.XPath("//*[@id='igCoreRadioButtoncomment_likes1']");
        private By LikeAndCommentOnPhotoXpath => By.XPath("//*[@id='igCoreRadioButtonlike_and_comment_on_photo_user_tagged2']");
        private By AcceptedFollowRequestXpath => By.XPath("//*[@id='igCoreRadioButtonfollow_request_accepted3']");
        private By InstagramDirectRequestXpath => By.XPath("//*[@id='igCoreRadioButtonpending_direct_share3']");
        private By InstagramDirectXpath => By.XPath("//*[@id='igCoreRadioButtondirect_share_activity1']");
        private By RemindersXpath => By.XPath("//*[@id='igCoreRadioButtonnotification_reminders1']");
        private By FirstPostAndStoriesXpath => By.XPath("//*[@id='igCoreRadioButtonfirst_post2']");
        private By VideoViewCountXpath => By.XPath("//*[@id='igCoreRadioButtonview_count1']");
        private By SupportRequestXpath => By.XPath("//*[@id='igCoreRadioButtonreport_updated1']");
        private By LiveVideosXpath => By.XPath("//*[@id='igCoreRadioButtonlive_broadcast3']");
        private By ManageContactsXpath => By.XPath("//a[contains(text(),'Manage Contacts')]");
        private By PrivacyAndSecurityXpath => By.XPath("//a[contains(text(),'Privacy and Security')]");
        private By ActivityStatusXpath => By.XPath("//*[@id='activityStatus']/label/div");
        private By AccountPrivacyXpath => By.XPath("//*[@id='accountPrivacy']/label/div");
        private By PrivateAccountXpath => By.XPath("//button[contains(text(),'Okay')]");
        private By StorySharingXpath => By.XPath("//*[@id='feedPostReshareDisabled']/label/div");
        private By PhotosOfYouXpath => By.XPath("//*[@id='igCoreRadioButtonusertagReviewEnabledautomatic']");
        private By AccountDataXpath => By.XPath("//a[contains(text(),'View Account Data')]");
        private By SupportXpath => By.XPath("//a[contains(text(),'Support')]");
        private By MentionsXpath => By.XPath("//*[@id='react-root']/section/main/div/article/main/section[10]/div[3]/div/div/div/div/div[2]");
        private By PostsXpath => By.XPath("//*[@id='react-root']/section/main/div/article/main/section[11]/div[3]/div/div/div/div[1]/div/div[2]/div[2]/div/label");
        private By AllowTagsXpath => By.XPath("//*[@id='react-root']/section/main/div/article/main/section[11]/div[3]/div/div/div/div[3]/div/div/div[2]");
        private By PrivacyAndSecurity_CommentsXpath => By.XPath("//a[contains(text(),'Edit Comment Settings')]");
        private By PrivacyAndSecurity_CmntTextAreaXpath => By.XPath("//*[@id='react-root']/section/main/div/article/div/form/textarea");
        private By PrivacyAndSecurity_submitBtnXpath => By.XPath("//button[contains(text(),'Submit')]");



        public SettingsPage(IWebDriver driver)
        {
            this._driver = driver;
        }

        private IWebElement ChangePassword => _driver.FindElement(ChangePasswordXpath);
        private IWebElement PasswordAssertion => _driver.FindElement(PasswordAssertionXpath);
        private IWebElement OldPassword => _driver.FindElement(OldPasswordXpath);
        private IWebElement NewPassword => _driver.FindElement(NewPasswordXpath);
        private IWebElement CnfrmNewPassword => _driver.FindElement(CnfrmNewPasswordXpath);
        private IWebElement ChangePasswordButton => _driver.FindElement(ChangePasswordButtonXpath);
        private IWebElement AppsAndWebsite => _driver.FindElement(AppsAndWebsiteXpath);
        private IWebElement Active => _driver.FindElement(ActiveXpath);
        private IWebElement Expired => _driver.FindElement(ExpiredXpath);
        private IWebElement Removed => _driver.FindElement(RemovedXpath);
        private IWebElement EmailAndSms => _driver.FindElement(EmailAndSmsXpath);
        private IWebElement FeedBackEmail => _driver.FindElement(FeedBackEmailXpath);
        private IWebElement ReminderEmail => _driver.FindElement(ReminderEmailXpath);
        private IWebElement ProductEmail => _driver.FindElement(ProductEmailXpath);
        private IWebElement NewsEmail => _driver.FindElement(NewsEmailXpath);
        private IWebElement PushNotification => _driver.FindElement(PushNotificationXpath);
        private IWebElement Likes => _driver.FindElement(LikesXpath);
        private IWebElement Comments => _driver.FindElement(CommentsXpath);
        private IWebElement CommentLike => _driver.FindElement(CommentLikeXpath);
        private IWebElement LikeAndCommentOnPhoto => _driver.FindElement(LikeAndCommentOnPhotoXpath);
        private IWebElement AcceptedFollowRequest => _driver.FindElement(AcceptedFollowRequestXpath);
        private IWebElement InstagramDirectRequest => _driver.FindElement(InstagramDirectRequestXpath);
        private IWebElement InstagramDirect => _driver.FindElement(InstagramDirectXpath);
        private IWebElement Reminders => _driver.FindElement(RemindersXpath);
        private IWebElement FirstPostAndStories => _driver.FindElement(FirstPostAndStoriesXpath);
        private IWebElement VideoViewCount => _driver.FindElement(VideoViewCountXpath);
        private IWebElement SupportRequest => _driver.FindElement(SupportRequestXpath);
        private IWebElement LiveVideos => _driver.FindElement(LiveVideosXpath);
        private IWebElement ManageContacts => _driver.FindElement(ManageContactsXpath);
        private IWebElement PrivacyAndSecurity => _driver.FindElement(PrivacyAndSecurityXpath);
        private IWebElement ActivityStatus => _driver.FindElement(ActivityStatusXpath);
        private IWebElement AccountPrivacy => _driver.FindElement(AccountPrivacyXpath);
        private IWebElement PrivateAccount => _driver.FindElement(PrivateAccountXpath);
        private IWebElement StorySharing => _driver.FindElement(StorySharingXpath);
        private IWebElement PhotosOfYou => _driver.FindElement(PhotosOfYouXpath);
        private IWebElement AccountData => _driver.FindElement(AccountDataXpath);
        private IWebElement Support => _driver.FindElement(SupportXpath);
        private IWebElement Mentions => _driver.FindElement(MentionsXpath);
        private IWebElement Posts => _driver.FindElement(PostsXpath);
        private IWebElement AllowTags => _driver.FindElement(AllowTagsXpath);
        private IWebElement PrivacyAndSecurity_Comments => _driver.FindElement(PrivacyAndSecurity_CommentsXpath);
        private IWebElement PrivacyAndSecurity_CmntTextArea => _driver.FindElement(PrivacyAndSecurity_CmntTextAreaXpath);
        private IWebElement PrivacyAndSecurity_submitBtn => _driver.FindElement(PrivacyAndSecurity_submitBtnXpath);





        public void ClickOnChangePassword()
        {
            ChangePassword.Click();
        }

        public string CheckOnPasswordAssertion()
        {
            return PasswordAssertion.Text;
        }

        public void EnterOldPassword(string oldPass)
        {
            OldPassword.SendKeys(oldPass);
        }

        public void EnterNewPassword(string newPass)
        {
            NewPassword.SendKeys(newPass);
        }

        public void EnterCnfrmNewPassword(string cnfrmPass)
        {
            CnfrmNewPassword.SendKeys(cnfrmPass);
        }

        public void ClickOnChangePasswordButton()
        {
            ChangePasswordButton.Click();
        }

        public void ClickOnAppsAndWebsite()
        {
            AppsAndWebsite.Click();
        }

        public void ClickOnActive()
        {
            Active.Click();
        }

        public void ClickOnExpired()
        {
            Expired.Click();
        }

        public void ClickOnRemoved()
        {
            Removed.Click();
        }

        public void ClickOnEmailAndSms()
        {
            EmailAndSms.Click();
        }

        public void ClickOnFeedBackEmail()
        {
            FeedBackEmail.Click();
        }

        public void ClickOnReminderEmail()
        {
            ReminderEmail.Click();
        }

        public void ClickOnProductEmail()
        {
            ProductEmail.Click();
        }

        public void ClickOnNewsEmail()
        {
            NewsEmail.Click();
        }

        public void ClickOnPushNotification()
        {
            PushNotification.Click();
        }

        public void ClickOnLikes()
        {
            Likes.Click();
        }

        public void ClickOnComments()
        {
            Comments.Click();
        }

        public void ClickOnCommentLike()
        {
            CommentLike.Click();
        }

        public void ClickOnLikeAndCommentOnPhoto()
        {
            LikeAndCommentOnPhoto.Click();
        }

        public void ClickOnAcceptedFollowRequest()
        {
            AcceptedFollowRequest.Click();
        }

        public void ClickOnInstagramDirectRequest()
        {
            InstagramDirectRequest.Click();
        }

        public void ClickOnInstagramDirect()
        {
            InstagramDirect.Click();
        }

        public void ClickOnReminders()
        {
            Reminders.Click();
        }

        public void ClickOnFirstPostAndStories()
        {
            FirstPostAndStories.Click();
        }

        public void ClickOnVideoViewCount()
        {
            VideoViewCount.Click();
        }

        public void ClickOnSupportRequest()
        {
            SupportRequest.Click();
        }

        public void ClickOnLiveVideos()
        {
            LiveVideos.Click();
        }

        public void ClickOnManageContacts()
        {
            ManageContacts.Click();
        }

        public void ClickOnPrivacyAndSecurity()
        {
            PrivacyAndSecurity.Click();
        }

        public void ClickOnActivityStatus()
        {
            ActivityStatus.Click();
        }

        public void ClickOnAccountPrivacy()
        {
            AccountPrivacy.Click();
        }

        public void ClickOnPrivateAccount()
        {
            PrivateAccount.Click();
        }

        public void ClickOnStorySharing()
        {
            StorySharing.Click();
        }

        public void ClickOnPhotosOfYou()
        {
            PhotosOfYou.Click();
        }

        public void ClickOnAccountData()
        {
            AccountData.Click();
        }

        public void ClickOnSupport()
        {
            Support.Click();
        }

        public void ClickOnMentions()
        {
            Mentions.Click();
        }

        public void ClickOnPosts()
        {
            Posts.Click();
        }

        public void ClickOnAllowTags()
        {
            AllowTags.Click();
        }

        public void ClickOnPrivacyAndSecurity_Comments()
        {
            PrivacyAndSecurity_Comments.Click();
        }

        public void EnterPrivacyAndSecurity_CmntTextArea(string textarea)
        {
            PrivacyAndSecurity_CmntTextArea.SendKeys(textarea);
        }

        public void ClickOnPrivacyAndSecurity_submitBtn()
        {
            PrivacyAndSecurity_submitBtn.Click();
        }

    }
}
