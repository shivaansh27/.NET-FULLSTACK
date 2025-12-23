using System;
class Patient
{
    private int patientId;
    public string name;
    public int age;
    private string medicalHistory;

    public Patient()
    {
        patientId = 0;
        name = null;
        age = 0;
        medicalHistory = null;
    }
    
    public int patientId
    {
        get
        {
            return patientId;
        }
    }

    public Patient(int patientId, string name, int age, string medicalHistory)
    {
        this.patientId = patientId;
        this.name = name;
        this.age = age;
        this.medicalHistory = medicalHistory;
    }

    public Patient(int patientId,string name, int age)
    {
        this.patientId = patientId;
        this.name = name;
        this.age = age;
    }

    public string MedicalHistory
    {
        get
        {
            return medicalHistory;
        }
        set
        {
            medicalHistory = value;
        }
    }


}