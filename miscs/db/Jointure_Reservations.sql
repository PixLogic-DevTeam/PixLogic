 CREATE VIEW ReservationExport AS SELECT ReservationEvents.Id AS "Numéro de la réservation",
Accounts.Email AS "Personne ayant réservée",
ReservationPlanningsInitial.BeginningDate AS "Début estimé de la réservation",
ReservationPlanningsReal.BeginningDate AS "Début réel de la réservation",
ReservationPlanningsInitial.EndingDate AS "Fin estimée de la réservation",
ReservationPlanningsReal.EndingDate AS "Fin réel de la réservation",
Packs.Name AS "Nom du pack utilisé", 
ItemBrands.Name AS "Marque", 
Items.Reference AS "Référence", 
ItemStatesInitial.Name AS "Etat avant la réservation",
ItemStatesReturn.Name AS "Etat après la réservation",
ItemStatesCurrent.Name AS "Etat actuel"
FROM ReservationItems INNER JOIN ReservationEvents 
ON ReservationItems.Reservation = ReservationEvents.Id 
INNER JOIN ReservationPlannings AS ReservationPlanningsInitial 
ON ReservationEvents.InitialPlanning = ReservationPlanningsInitial.Id
INNER JOIN ReservationPlannings AS ReservationPlanningsReal
ON ReservationItems.RealPlanning = ReservationPlanningsReal.Id
INNER JOIN Packs
ON ReservationItems.ReservedPack = Packs.Id
INNER JOIN Items
ON ReservationItems.ReservedItem = Items.Id
INNER JOIN ItemBrands
ON Items.Brand = ItemBrands.Id
INNER JOIN ItemStates AS ItemStatesInitial
ON ReservationItems.InitialState = ItemStatesInitial.Id
INNER JOIN ItemStates AS ItemStatesReturn
ON ReservationItems.ReturnState = ItemStatesReturn.Id
INNER JOIN ItemStates AS ItemStatesCurrent
ON Items.CurrentState = ItemStatesCurrent.Id
INNER JOIN Accounts
ON ReservationEvents.Reserver = Accounts.Id;
