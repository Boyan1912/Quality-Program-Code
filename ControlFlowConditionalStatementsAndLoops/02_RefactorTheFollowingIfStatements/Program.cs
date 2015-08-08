/* Refactor the following if statements

Potato potato;
//... 
if (potato != null)
   if(!potato.HasNotBeenPeeled && !potato.IsRotten)
    Cook(potato);

and

if (x >= MIN_X && (x =< MAX_X && ((MAX_Y >= y && MIN_Y <= y) && !shouldNotVisitCell)))
{
   VisitCell();
}
*/

Potato myPotato = new Potato();
//... 
if (potato != null && potato.IsWhole && potato.IsFresh)
    {
        Cook(potato);
    }
   

bool xIsInRange = MIN_X <= x && x <= MAX_X;
bool yIsInRange = MIN_Y <= y && y <= MAX_Y;
if (xIsInRange && yIsInRange && shouldVisitCell)
{
   VisitCell();
}