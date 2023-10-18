Buffet buffet = new Buffet();

Ninja ninja1 = new Ninja();

// ninja1.Eat(buffet.Serve());

while(!ninja1.IsFull){
    ninja1.Eat(buffet.Serve());
}