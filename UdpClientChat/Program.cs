﻿using UdpClientChat;

internal class Program
{
    private static void Main(string[] args)
    {
        UDPChat uDPChat = new UDPChat();
        uDPChat.handlerChat();
        Console.WriteLine("Hello, World!");
    }
}