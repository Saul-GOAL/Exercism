using System;
using System.Linq;
using System.Collections.Generic;
public static class BookStore
{
    private static readonly int _bookPrice = 8;
    private static readonly decimal[] _discounts = { 0m, 0.05m, 0.1m, 0.2m, 0.25m };
    
    public static decimal Total(IEnumerable<int> books)
    {
        (int[] books, decimal cartPrice) bookCart = CreateCart(books);
        return ComputeCartLowerPrice(bookCart);
    }

    // Ordering the Books by number of copies of each.
    private static decimal ComputeCartLowerPrice((int[] books, decimal cartPrice) bookCart) 
    {
        if (bookCart.books.All(b => b == 0))
        {
            return bookCart.cartPrice;
        }

        var minPrice = decimal.MaxValue;
        
        // We Try every bundling combination, and we keep the cheapest one.
        for (int i = bookCart.books.Count(b => b != 0); i > 0; i--) 
        {
            decimal totalExpenses = bookCart.cartPrice + BundlePrice(i);
            var remainingCart = bookCart.books.Select((b, n) => n <= i - 1 ? b - 1 : b).OrderByDescending(b => b).ToArray();
            minPrice = Math.Min(minPrice, ComputeCartLowerPrice((remainingCart, totalExpenses)));
        }
        return minPrice;
    }
    private static decimal BundlePrice(int bundleSize) => _bookPrice * bundleSize * (1 - _discounts[bundleSize - 1]);
    private static (int[] books, decimal cartPrice) CreateCart(IEnumerable<int> books)
    {
        var bookCart = new int[5];
        for (int i = 0; i < 5; i++)
        {
            bookCart[i] = books.Count(b => b == i + 1);
        }
        bookCart = bookCart.OrderByDescending(b => b).ToArray();
        return (bookCart, 0);
    }
}