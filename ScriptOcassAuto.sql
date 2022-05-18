CREATE DATABASE IF NOT EXISTS bdOccasion2;
use bdOccasion2;

DROP TABLE IF EXISTS Concessionaire;

CREATE TABLE IF NOT EXISTS Concessionaire
(
	idConces INT(2) auto_increment,
    nom VARCHAR(15),
    prenom VARCHAR(15),
    adresse VARCHAR(50),
    codePostal VARCHAR(5),
    ville VARCHAR(20),
    PRIMARY KEY (idConces) 
)
ENGINE=InnoDB DEFAULT CHARSET=utf8;
CREATE TABLE IF NOT EXISTS Users
(
	id INT(2) auto_increment,
    login VARCHAR(15),
    mdp VARCHAR(15),
    mail VARCHAR(50),
    PRIMARY KEY (id) 
)
ENGINE=InnoDB DEFAULT CHARSET=utf8;


INSERT INTO Concessionaire (nom,prenom,adresse,codePostal,ville) VALUES 
('Davolio', 'Jeanne', '5 rue de la poste', '63000', 'CLERMONT-FERRAND'),
('Fuller', 'Philippe', '254 avenue Berthelot', '63000', 'CLERMONT-FERRAND'),
('Daverling', 'Laura', '1 place de Jaude', '63000', 'CLERMONT-FERRAND'),
('Peacock', 'Emilie', '23, Impasse des Fleurs', '63000', 'CLERMONT-FERRAND'),
('Buchanan', 'Pierre', '32 place de l''Hôtel de Ville', '63200', 'RIOM'),
('Bucyama', 'Michel', '15 rue des pinsons', '63200', 'RIOM'),
('King', 'Louis', '57 rue de la gare', '63500', 'ISSOIRE'),
('Callahan', 'Jean', '23 boulevard Central', '63500', 'ISSOIRE'),
('Bucsworth', 'Pierre', '7 rue de la paix', '63500', 'ISSOIRE');