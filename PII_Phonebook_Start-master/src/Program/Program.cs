using System;
using Library;
using System.Collections.Generic;

namespace Program
{
    public class Program
    {
        static void Main(string[] args)
        {
            Contact owner = new Contact("wppUcu", "+14155238886",""); 
            // Crear el contacto dueño

            Phonebook book = new Phonebook(owner);
            // Crear la lista de contactos

            book.Add ("paolo","+59892370344","1174842747842416640");
            book.Add ("santiago","+59898437684","");
            book.Add ("seba","+59898396922","1175133180854243328");
            // Agregar contactos a la lista

            // Enviar un correo a algunos contactos

            List<Contact> ContactsBook = book.Search(new string []{"paolo"});
            foreach(Contact contacts in ContactsBook)
            {
                book.SendWPPMessage(contacts, "hola bro");
                book.SendTwitterMessage(contacts, "hola bro");
            }
            // Enviar un WhatsApp a algunos contactos

            // Enviar un mensaje en Twitter
        }
    }
}
