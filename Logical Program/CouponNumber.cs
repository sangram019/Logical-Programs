namespace LogicalPrograms
{
    public class CouponNumber
    {
        public void coupon()
        {
            Console.WriteLine("Enter number of coupons");
            int number = int.Parse(Console.ReadLine());
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            Random random = new Random();
            string result = new string(
                Enumerable.Repeat(chars, 8)
                          .Select(s => s[random.Next(s.Length)])
                          .ToArray());
            Console.Write("Your coupon number is " + result);
        }


    }
}