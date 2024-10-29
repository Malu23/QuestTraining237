// A class should have one and only one reason to change, meaning that a class should have only one job.

class User
{
    public string Name { get; set; }
    public string Email { get; set; }
}

class EmailService
{
    public void SendEmail(User user)
    {
        
    }
    
    public void ReceiveEmail(User user)
    {
        
    }
}