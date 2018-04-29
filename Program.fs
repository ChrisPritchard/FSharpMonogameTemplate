module MyGameEntry

open MyGame

[<EntryPoint>]
let main _ =
    use game = new Game1()
    game.Run()
    0