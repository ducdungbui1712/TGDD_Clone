namespace TGDD_Clone_2.Services;
public class OrderState
{
        public Order Order { get; private set; } = new Order();
        public Phone ConfiguringPhone { get; private set; }

        public void AddPhoneToOrder(Phone phone)
        {
            Order.Phones.Add(phone);
        }

public void RemovePhoneFromOrder(Phone phone)
{
    Order.Phones.Remove(phone);
}

public void ResetOrder()
{
    Order = new Order();
}

}