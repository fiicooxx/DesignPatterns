using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    internal class PinInserted : State
    {
        public PinInserted(Context context) : base(context)
        {
        }
        public override void EjectCard()
        {
            Console.WriteLine("Card ejected");
            _context.ChangeState(new NoCard(_context));
        }

        public override void InsertCard()
        {
            Console.WriteLine("You have already inserted a card");
        }

        public override void InsertPin(int pin)
        {
            Console.WriteLine("You have already inserted correct PIN");
        }

        public override void WithdrawCash(int amount)
        {
            if (amount <= _context.Cash)
            {
                Console.WriteLine($"You withdrawn {amount}");
                _context.Cash -= amount;

                if (_context.Cash == 0)
                {
                    _context.ChangeState(new NoCash(_context));
                    Console.WriteLine("Your balance is 0 now");
                }

                else
                {
                    Console.WriteLine("Card ejected");
                    _context.ChangeState(new NoCard(_context));
                }
            }
            else
                Console.WriteLine("The amount of cash is not available");
        }
    }
}
