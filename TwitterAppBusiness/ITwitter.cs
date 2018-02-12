namespace TwitterAppBusiness
{
    interface ITwitter:ISocialMedia<ISocialMediaObject>
    {
        int Count { get; set; }
        
    }
}
