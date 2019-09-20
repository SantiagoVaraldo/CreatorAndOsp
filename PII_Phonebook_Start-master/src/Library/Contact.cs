namespace Library
{
         public class Contact
         {
                  // tenia solo name de parametro
                  public Contact(string name, string phone, string idTwitter)
                  {
                           this.name = name;
                           this.phone = phone;
                           this.idTwitter = idTwitter;
                  }

                  // encapsule algunos atributos
                  private string name;
                  private string idTwitter;
                  private string phone;
                  private string email;
                  public string Name
                  {
                           get
                           {
                                    return this.name;
                           }
                           set
                           {
                                    if (!string.IsNullOrEmpty(value))
                                    {
                                             this.name = value;
                                    }
                           }
                  }

                  public string Phone
                  {
                           get
                           {
                                    return this.phone;
                           }
                           set
                           {
                                    if (!string.IsNullOrEmpty(value))
                                    {
                                             this.phone = value;
                                    }
                           }
                  }

                  public string IdTwitter
                  {
                           get
                           {
                                    return this.idTwitter;
                           }
                           set
                           {
                                    if (!string.IsNullOrEmpty(value))
                                    {
                                             this.idTwitter = value;
                                    }
                           }
                  }
         }
}