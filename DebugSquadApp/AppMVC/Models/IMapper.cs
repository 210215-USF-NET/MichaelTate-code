namespace AppMVC.Models
{
    public interface IMapper
    {
        User ParseUser(CustomerCRVM newUser);
        CustomerIndexVM cast2CustomerIndexVM(Customer customer)
    }
}