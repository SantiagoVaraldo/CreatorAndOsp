using System.Collections.Generic;
using WhatsAppApiUCU;
using System;

namespace Library
{
         public class Phonebook
         {
                  private List<Contact> persons;

                  public Phonebook(Contact owner)
                  {
                           this.Owner = owner;
                           this.persons = new List<Contact>();
                  }

                  public Contact Owner { get; }

                  public List<Contact> Search(string[] names)
                  {
                           List<Contact> result = new List<Contact>();

                           foreach (Contact person in this.persons)
                           {
                                    foreach (string name in names)
                                    {
                                             if (person.Name.Equals(name))
                                             {
                                                      result.Add(person);
                                             }
                                    }
                           }

                           return result;
                  }
                  public void Add(string name, string phone, string idTwitter)
                  {
                           Contact NewContact = new Contact(name, phone, idTwitter);
                           this.persons.Add(NewContact);
                  }
                  public void Remove(Contact contact)
                  {
                           this.persons.Remove(contact);
                  }
                  public void SendWPPMessage(Contact contact, string text)
                  {
                           if (this.persons.Contains(contact))
                           {
                                    Message message = new Message("UCU_WPP",contact.Phone,text);
                                    WPPChannel wppchannel = new WPPChannel();
                                    wppchannel.Send(message.From, message.To, message.Text);
                           }
                  }
                  public void SendTwitterMessage(Contact contact, string text)
                  {
                           if (this.persons.Contains(contact))
                           {
                                    Message message = new Message("UCU_WPP",contact.IdTwitter,text);
                                    twitterChannel twitterchannel = new twitterChannel();
                                    twitterchannel.Send(message.From, message.To, message.Text);
                  }
                  }

         }
}