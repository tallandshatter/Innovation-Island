Public Class Innovation_Island
    Private Property IslandName As String
    Private Property NumberOfInhabitants As Integer
    Private Property SizeInSquareMiles As Double

    Sub Main()
        Dim island As New Innovation_Island("Innovation Island", 10, 100.25)
        'Display island information
        Console.WriteLine("Innovation Island Information")
        Console.WriteLine("Name: " & island.IslandName)
        Console.WriteLine("Number of Inhabitants: " & island.NumberOfInhabitants)
        Console.WriteLine("Size in Square Miles: " & island.SizeInSquareMiles)
    End Sub

    'Create constructor
    Sub New(ByVal name As String, ByVal inhabitants As Integer, ByVal size As Double)
        IslandName = name
        NumberOfInhabitants = inhabitants
        SizeInSquareMiles = size
    End Sub
End Class

Public Class Citizen
    Private Property CitizenName As String
    Private Property Age As Integer
    Private Property NumberOfDependents As Integer

    'Create constructor
    Sub New(ByVal name As String, ByVal age As Integer, ByVal dependents As Integer)
        CitizenName = name
        Age = age
        NumberOfDependents = dependents
    End Sub
End Class

Public Class Innovation_Island_Community
    Private Property Citizens As List(Of Citizen)
    Private Property SchoolName As String
    Private Property TownName As String
    Private Property Population As Integer

    Sub Main()
        Dim islandCommunity As New Innovation_Island_Community("Innovation Elementary", "Innovation Town", 500)
        Console.WriteLine("Innovation Island Community Information")
        Console.WriteLine("School Name: " & islandCommunity.SchoolName)
        Console.WriteLine("Town Name: " & islandCommunity.TownName)
        Console.WriteLine("Population: " & islandCommunity.Population)
    End Sub

    'Create constructor
    Sub New(ByVal school As String, ByVal town As String, ByVal pop As Integer)
        SchoolName = school
        TownName = town
        Population = pop
        Citizens = New List(Of Citizen)
    End Sub

    'Method to add citizens
    Public Sub AddCitizen(ByVal name As String, ByVal age As Integer, ByVal dependents As Integer)
        Dim citizen As New Citizen(name, age, dependents)
        Citizens.Add(citizen)
    End Sub
End Class

Public Class Island_Growth
    Private Property IslandName As String
    Private Property HistoricalGrowthRate As Double
    Private Property ForecastedGrowthRate As Double
    Private Property CurrentPopulation As Integer

    Sub Main()
        Dim islandGrowth As New Island_Growth("Innovation Island", 1.2, 1.4, 1000)
        Console.WriteLine("Innovation Island Growth Information")
        Console.WriteLine("Name: " & islandGrowth.IslandName)
        Console.WriteLine("Historical Growth Rate: " & islandGrowth.HistoricalGrowthRate)
        Console.WriteLine("Forecasted Growth Rate: " & islandGrowth.ForecastedGrowthRate)
        Console.WriteLine("Current Population: " & islandGrowth.CurrentPopulation)
    End Sub

    'Create constructor
    Sub New(ByVal name As String, ByVal histRate As Double, ByVal forecastRate As Double, ByVal population As Integer)
        IslandName = name
        HistoricalGrowthRate = histRate
        ForecastedGrowthRate = forecastRate
        CurrentPopulation = population
    End Sub
End Class

Public Class Innovation_Island_Economy
    Private Property CurrencyName As String
    Private Property ExchangeRate As Decimal
    Private Property GDPPerCapita As Decimal
    Private Property GDPTotal As Decimal

    Sub Main()
        Dim islandEconomy As New Innovation_Island_Economy("Innovation Dollars", 1.2, 25000, 100000000)
        Console.WriteLine("Innovation Island Economic Information")
        Console.WriteLine("Currency Name: " & islandEconomy.CurrencyName)
        Console.WriteLine("Exchange Rate: " & islandEconomy.ExchangeRate)
        Console.WriteLine("GDP per Capita: " & islandEconomy.GDPPerCapita)
        Console.WriteLine("GDP Total: " & islandEconomy.GDPTotal)
    End Sub

    'Create constructor
    Sub New(ByVal currencyName As String, ByVal rate As Decimal, ByVal gdpPerCap As Decimal, ByVal gdpTotal As Decimal)
        CurrencyName = currencyName
        ExchangeRate = rate
        GDPPerCapita = gdpPerCap
        GDPTotal = gdpTotal
    End Sub
End Class

Public Class Island_Weather
    Private Property CurrentTemperature As Double
    Private Property AverageHigh As Double
    Private Property AverageLow As Double
    Private Property WindSpeed As Double

    Sub Main()
        Dim islandWeather As New Island_Weather(72.5, 75.5, 69.5, 10.2)
        Console.WriteLine("Innovation Island Weather Information")
        Console.WriteLine("Current Temperature: " & islandWeather.CurrentTemperature)
        Console.WriteLine("Average High: " & islandWeather.AverageHigh)
        Console.WriteLine("Average Low: " & islandWeather.AverageLow)
        Console.WriteLine("Wind Speed: " & islandWeather.WindSpeed)
    End Sub

    'Create constructor
    Sub New(ByVal temp As Double, ByVal high As Double, ByVal low As Double, ByVal speed As Double)
        CurrentTemperature = temp
        AverageHigh = high
        AverageLow = low
        WindSpeed = speed
    End Sub
End Class

Public Class Island_Tourism
    Private Property NumberOfVisitors As Integer
    Private Property NumberOfHotels As Integer
    Private Property NumberOfRestaurants As Integer
    Private Property NumberOfAttractions As Integer

    Sub Main()
        Dim islandTourism As New Island_Tourism(10000, 10, 50, 20)
        Console.WriteLine("Innovation Island Tourism Information")
        Console.WriteLine("Number of Visitors: " & islandTourism.NumberOfVisitors)
        Console.WriteLine("Number of Hotels: " & islandTourism.NumberOfHotels)
        Console.WriteLine("Number of Restaurants: " & islandTourism.NumberOfRestaurants)
        Console.WriteLine("Number of Attractions: " & islandTourism.NumberOfAttractions)
    End Sub

    'Create constructor
    Sub New(ByVal visitors As Integer, ByVal hotels As Integer, ByVal restaurants As Integer, ByVal attractions As Integer)
        NumberOfVisitors = visitors
        NumberOfHotels = hotels
        NumberOfRestaurants = restaurants
        NumberOfAttractions = attractions
    End Sub
End Class

Public Class Tourism_Income
    Private Property TouristIncome As Decimal
    Private Property TaxIncome As Decimal
    Private Property CombinedIncome As Decimal

    Sub Main()
        Dim touristIncome As New Tourism_Income(1000000, 100000, 1100000)
        Console.WriteLine("Innovation Island Tourism Income Information")
        Console.WriteLine("Tourist Income: " & touristIncome.TouristIncome)
        Console.WriteLine("Tax Income: " & touristIncome.TaxIncome)
        Console.WriteLine("Combined Income: " & touristIncome.CombinedIncome)
    End Sub

    'Create constructor
    Sub New(ByVal touristIncome As Decimal, ByVal taxIncome As Decimal, ByVal combinedIncome As Decimal)
        TouristIncome = touristIncome
        TaxIncome = taxIncome
        CombinedIncome = combinedIncome
    End Sub
End Class

Public Class Island_Health
    Private Property NumberOfHospitals As Integer
    Private Property NumberOfDoctors As Integer
    Private Property NumberOfNurses As Integer
    Private Property NumberOfPatients As Integer

    Sub Main()
        Dim islandHealth As New Island_Health(2, 30, 100, 1000)
        Console.WriteLine("Innovation Island Health Information")
        Console.WriteLine("Number of Hospitals: " & islandHealth.NumberOfHospitals)
        Console.WriteLine("Number of Doctors: " & islandHealth.NumberOfDoctors)
        Console.WriteLine("Number of Nurses: " & islandHealth.NumberOfNurses)
        Console.WriteLine("Number of Patients: " & islandHealth.NumberOfPatients)
    End Sub

    'Create constructor
    Sub New(ByVal hospitals As Integer, ByVal doctors As Integer, ByVal nurses As Integer, ByVal patients As Integer)
        NumberOfHospitals = hospitals
        NumberOfDoctors = doctors
        NumberOfNurses = nurses
        NumberOfPatients = patients
    End Sub
End Class

Public Class Island_Governance
    Private Property PoliticalSystem As String
    Private Property GovernmentType As String
    Private Property LawEnforcement As String
    Private Property CourtSystem As String

    Sub Main()
        Dim islandGoverance As New Island_Governance("Democratic", "Representative Democracy", "Local Police Force", "Supreme Court")
        Console.WriteLine("Innovation Island Governance Information")
        Console.WriteLine("Political System: " & islandGoverance.PoliticalSystem)
        Console.WriteLine("Government Type: " & islandGoverance.GovernmentType)
        Console.WriteLine("Law Enforcement: " & islandGoverance.LawEnforcement)
        Console.WriteLine("Court System: " & islandGoverance.CourtSystem)
    End Sub

    'Create constructor
    Sub New(ByVal politicalSystem As String, ByVal govType As String, ByVal enforcement As String, ByVal courtSystem As String)
        PoliticalSystem = politicalSystem
        GovernmentType = govType
        LawEnforcement = enforcement
        CourtSystem = courtSystem
    End Sub
End Class

Public Class Island_Infrastructure
    Private Property Roads As Integer
    Private Property WaterSystem As String
    Private Property PowerSystem As String
    Private Property SewageSystem As String

    Sub Main()
        Dim islandInfrastructure As New Island_Infrastructure(100, "Public Utility", "Public Utility", "Public Utility")
        Console.WriteLine("Innovation Island Infrastructure Information")
        Console.WriteLine("Number of Roads: " & islandInfrastructure.Roads)
        Console.WriteLine("Water System: " & islandInfrastructure.WaterSystem)
        Console.WriteLine("Power System: " & islandInfrastructure.PowerSystem)
        Console.WriteLine("Sewage System: " & islandInfrastructure.SewageSystem)
    End Sub

    'Create constructor
    Sub New(ByVal roads As Integer, ByVal water As String, ByVal power As String, ByVal sewage As String)
        Roads = roads
        WaterSystem = water
        PowerSystem = power
        SewageSystem = sewage
    End Sub
End Class

Public Class Island_Education
    Private Property NumberOfSchools As Integer
    Private Property NumberOfTeachers As Integer
    Private Property NumberOfStudents As Integer
    Private Property EducationLevels As String

    Sub Main()
        Dim islandEducation As New Island_Education(5, 50, 1000, "Primary, Secondary, and Post-Secondary")
        Console.WriteLine("Innovation Island Education Information")
        Console.WriteLine("Number of Schools: " & islandEducation.NumberOfSchools)
        Console.WriteLine("Number of Teachers: " & islandEducation.NumberOfTeachers)
        Console.WriteLine("Number of Students: " & islandEducation.NumberOfStudents)
        Console.WriteLine("Education Levels: " & islandEducation.EducationLevels)
    End Sub

    'Create constructor
    Sub New(ByVal schools As Integer, ByVal teachers As Integer, ByVal students As Integer, ByVal levels As String)
        NumberOfSchools = schools
        NumberOfTeachers = teachers
        NumberOfStudents = students
        EducationLevels = levels
    End Sub
End Class

Public Class Island_Innovation
    Private Property NumberOfTechCompanies As Integer
    Private Property NumberOfInventors As Integer
    Private Property NumberOfInventions As Integer
    Private Property NumberOfStartups As Integer

    Sub Main()
        Dim islandInnovation As New Island_Innovation(4, 15, 50, 20)
        Console.WriteLine("Innovation Island Innovation Information")
        Console.WriteLine("Number of Tech Companies: " & islandInnovation.NumberOfTechCompanies)
        Console.WriteLine("Number of Inventors: " & islandInnovation.NumberOfInventors)
        Console.WriteLine("Number of Inventions: " & islandInnovation.NumberOfInventions)
        Console.WriteLine("Number of Startups: " & islandInnovation.NumberOfStartups)
    End Sub

    'Create constructor
    Sub New(ByVal techCompanies As Integer, ByVal inventors As Integer, ByVal inventions As Integer, ByVal startups As Integer)
        NumberOfTechCompanies = techCompanies
        NumberOfInventors = inventors
        NumberOfInventions = inventions
        NumberOfStartups = startups
    End Sub
End Class

Public Class Island_Culture
    Private Property PrimaryLanguages As String
    Private Property PopularSports As String
    Private Property Music As String
    Private Property Arts As String

    Sub Main()
        Dim islandCulture As New Island_Culture("English, French, and Spanish", "Soccer and Cricket", "Pop and Reggae", "Sculpture and Painting")
        Console.WriteLine("Innovation Island Culture Information")
        Console.WriteLine("Primary Languages: " & islandCulture.PrimaryLanguages)
        Console.WriteLine("Popular Sports: " & islandCulture.PopularSports)
        Console.WriteLine("Music: " & islandCulture.Music)
        Console.WriteLine("Arts: " & islandCulture.Arts)
    End Sub

    'Create constructor
    Sub New(ByVal languages As String, ByVal sports As String, ByVal music As String, ByVal arts As String)
        PrimaryLanguages = languages
        PopularSports = sports
        Music = music
        Arts = arts
    End Sub
End Class