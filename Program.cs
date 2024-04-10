

using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

Patient first = new Doctor("Alex", 25052001, 45879651, "Hirurg" );


public class Patient
{
    private string name;
    private int date_of_birth;
    private double insurancenumber;


    public string Name
    { 
        get 
        { 
            return name; 
        } 
    }
    public int Date_of_birth 
    {   get 
       {
            return date_of_birth; 
       }
        set 
        {
            date_of_birth = value;
        }
    }
    public double Insurancenumber 
    
    {    get 
        { 
            return insurancenumber;
        } 
        set
        {
            insurancenumber = value;    
        }
    }

    public Patient (string name, int date_of_birth, double insurancenumber )
    {
        this.name = name;
        this.date_of_birth = date_of_birth;
        this.insurancenumber = insurancenumber; 
    }

    public virtual void RecordDiagnosis ( string diagnosis)
    {  
    }

    public virtual void ShowMedCard()
    {
     Console.WriteLine ( "Information about patient:" );

    }
}

public class Doctor : Patient
{
    private string specialization;

    public Doctor (string name, int date_of_birth, double insurancenumber, string specialization)
        : base (name, date_of_birth, insurancenumber)
    {
        this.specialization = specialization;
    }

    public virtual void SetDiagnosis (string diagnosis, Patient patient)
    {
        patient.RecordDiagnosis(diagnosis);
    }

}

public class MedCard : Patient
{
    private List<string> Diagnoses { get; set; }

    public MedCard(string name, int date_of_birth, double insurance_number)
        : base(name, date_of_birth, insurance_number)
    {
        Diagnoses = new List<string>();
    }

    public override void RecordDiagnosis(string diagnosis)
    {
        Diagnoses.Add(diagnosis);
    }

    public override void ShowMedCard()
    {
        Console.WriteLine("Patient Name : " + Name);
        Console.WriteLine("Date_of_birth: " + Date_of_birth);
        Console.WriteLine("Insurance_number: " + Insurancenumber);
        Console.WriteLine("Diagnoses:");
        foreach (var diagnosis in Diagnoses)
        {
            Console.WriteLine(diagnosis);
        }
    }

}

