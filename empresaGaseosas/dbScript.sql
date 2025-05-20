DROP schema IF EXISTS Gaseosas;
CREATE schema Gaseosas;
USE Gaseosas;

CREATE TABLE Ciudades (
  idCiudad INT PRIMARY KEY,
  descripCiudad VARCHAR(50) NOT NULL
);

CREATE TABLE Tipos_Tiendas (
  idTienda INT PRIMARY KEY,	
  descripTienda VARCHAR(50) NOT NULL
);

CREATE TABLE Tipos_Documentos (
  idDocumento INT PRIMARY KEY,
  descripDocumento VARCHAR(30) NOT NULL
);

CREATE TABLE Niveles_Educativos (
  idNivel INT PRIMARY KEY,
  descripNivel VARCHAR(100) NOT NULL
);

CREATE TABLE Areas_Trabajos (
  idArea INT PRIMARY KEY,
  descripArea VARCHAR(100) NOT NULL
);

CREATE TABLE Estados (
  idEstado INT PRIMARY KEY,
  descripEstado VARCHAR(50) NOT NULL
);

CREATE TABLE Presentaciones_Productos (
  idPresentacion INT PRIMARY KEY,
  descripPresentacion VARCHAR(50) NOT NULL
);

CREATE TABLE Productos (
  idProducto INT PRIMARY KEY,
  valor DECIMAL(10,2) NOT NULL,
  presentacionProducto INT NOT NULL,
  descripcion VARCHAR(200) NOT NULL,
  estadoProducto INT NOT NULL,
  -- Relaciones (FK)
  CONSTRAINT fk_presentacionProducto
    FOREIGN KEY (presentacionProducto) 
    REFERENCES Presentaciones_Productos(idPresentacion),
  CONSTRAINT fk_estadoProducto
    FOREIGN KEY (estadoProducto)
    REFERENCES Estados(idEstado)
);

CREATE TABLE Clientes (
  idCliente INT PRIMARY KEY,
  tipoDoc INT NOT NULL,
  numeroDoc VARCHAR(15) NOT NULL,
  nombreCliente VARCHAR(50) NOT NULL,
  contrasenaCliente VARCHAR(45) NOT NULL,
  apellidoCliente VARCHAR(50) NOT NULL,
  ciudad INT NOT NULL,
  direccion VARCHAR(100) NOT NULL,
  cupoVenta DECIMAL(10,2) NOT NULL,
  tipoCliente INT NOT NULL,
  -- Relaciones (FK)
  CONSTRAINT fk_tipoDocCliente
    FOREIGN KEY (tipoDoc) REFERENCES Tipos_Documentos(idDocumento),
  CONSTRAINT fk_ciudadCliente
    FOREIGN KEY (ciudad) REFERENCES Ciudades(idCiudad),
  CONSTRAINT fk_tipoCliente
    FOREIGN KEY (tipoCliente) REFERENCES Tipos_Tiendas(idTienda),
  -- Restricción UNIQUE
  UNIQUE (tipoDoc, numeroDoc),
  UNIQUE (contrasenaCliente)
);

CREATE TABLE Empleados (
  idEmpleado INT PRIMARY KEY,
  tipoDoc INT,
  numeroDoc VARCHAR(15) NOT NULL,
  nombreEmpleado VARCHAR(50) NOT NULL,
  apellidoEmpleado VARCHAR(50) NOT NULL,
  correoEmpleado VARCHAR(150) NOT NULL,
  telefonoEmpleado VARCHAR(15) NOT NULL,
  contrasenaEmpleado VARCHAR(45) NOT NULL,
  fechaContratacion DATE NOT NULL,
  areaTrabajo INT NOT NULL,
  nivelEducativo INT NOT NULL,
  estadoEmpleado INT NOT NULL,
  -- Relaciones (FK)
  CONSTRAINT fk_tipoDocEmpleado
    FOREIGN KEY (tipoDoc) REFERENCES Tipos_Documentos(idDocumento),
  CONSTRAINT fk_areaTrabajo
    FOREIGN KEY (areaTrabajo) REFERENCES Areas_Trabajos(idArea),
  CONSTRAINT fk_nivelEducativo
    FOREIGN KEY (nivelEducativo) REFERENCES Niveles_Educativos(idNivel),
  CONSTRAINT fk_estadoEmpleado
    FOREIGN KEY (estadoEmpleado) REFERENCES estados(idEstado),
  -- Restricción UNIQUE
  UNIQUE (tipoDoc, numeroDoc),
  UNIQUE(correoEmpleado),
  UNIQUE(contrasenaEmpleado)
);

CREATE TABLE Flota_Vehiculos (
  placaVehiculo VARCHAR(6) PRIMARY KEY,
  idConductor INT NOT NULL,
  estadoVehiculo INT NOT NULL,
  ciudadVehiculo INT NOT NULL,
  capacidadVehiculo INT NOT NULL,
  -- Relaciones (FK)
  CONSTRAINT fk_conductor
    FOREIGN KEY (idConductor) REFERENCES Empleados(idEmpleado),
  CONSTRAINT fk_estadoVehiculo
    FOREIGN KEY (estadoVehiculo) REFERENCES Estados(idEstado),
  CONSTRAINT fk_ciudadVehiculo
    FOREIGN KEY (ciudadVehiculo) REFERENCES Ciudades(idCiudad)
);

CREATE TABLE Pedidos (
  idPedido INT PRIMARY KEY,
  idCliente INT NOT NULL,
  fechaPedido DATE NOT NULL,
  estadoPedido INT NOT NULL,
  vehiculoPedido VARCHAR(6) NOT NULL,
  -- Relaciones (FK)
  CONSTRAINT fk_clientePedido
    FOREIGN KEY (idCliente) REFERENCES Clientes(idCliente),
  CONSTRAINT fk_estadoPedido
    FOREIGN KEY (estadoPedido) REFERENCES Estados(idEstado),
  CONSTRAINT fk_vehiculoPedido
    FOREIGN KEY (vehiculoPedido) REFERENCES Flota_Vehiculos(placaVehiculo)
);

CREATE TABLE Detalles_Pedidos (
  idPedido INT,
  idProducto INT,
  cantidad INT NOT NULL,
  valor DECIMAL(10,2),
  PRIMARY KEY(idPedido, idProducto),
  -- Relaciones (FK)
  CONSTRAINT fk_pedidoDetalle
    FOREIGN KEY (idPedido) REFERENCES Pedidos(idPedido),
  CONSTRAINT fk_productoDetalle
    FOREIGN KEY (idProducto) REFERENCES Productos(idProducto)
);

-- Inserción de datos necesarios --
INSERT INTO estados VALUES 
(1, 'Activo'),
(2, 'Inactivo');

INSERT INTO presentaciones_productos VALUES 
(1, '350mL'), 
(2, '3L');

INSERT INTO Tipos_Documentos (idDocumento, descripDocumento) VALUES 
(1, 'Cédula de Ciudadanía'),
(2, 'Tarjeta de Identidad'),
(3, 'Cédula de Extranjería'),
(4, 'Pasaporte'),
(5, 'NIT'),
(6, 'Registro Civil'),
(7, 'Libreta Militar'),
(8, 'Documento de Identidad'),
(9, 'DNI'),
(10, 'Otro');

INSERT INTO Areas_Trabajos (idArea, descripArea) VALUES 
(1, 'Ventas'),
(2, 'Administración'),
(3, 'Logística'),
(4, 'Operaciones'),
(5, 'Finanzas'),
(6, 'Recursos Humanos'),
(7, 'Marketing'),
(8, 'Tecnología'),
(9, 'Atención al Cliente'),
(10, 'Producción');

INSERT INTO Niveles_Educativos (idNivel, descripNivel) VALUES 
(1, 'Primaria'),
(2, 'Secundaria'),
(3, 'Bachillerato'),
(4, 'Técnico'),
(5, 'Tecnólogo'),
(6, 'Pregrado'),
(7, 'Maestría'),
(8, 'Doctorado'),
(9, 'Postdoctorado'),
(10, 'Sin estudio');


-- Inserción de administrador --
INSERT INTO Empleados VALUES 
(1, 1, '1', 'admin', ' ', 'admin@mail.com', '1', '123456', '01-01-01', 2, 1,1);



DELIMITER $$
CREATE PROCEDURE  ActualizarProducto ( I_idProducto int, I_valor decimal(10,2), I_presentacionProducto int, I_descripcion varchar(200), I_estadoProducto int)
/****** 
Nombre: ActualizarProducto 
Autor: Sebastián Rave
Objetivo: Procedimiento que actualiza un producto de la base de datos de la tabla productos. 	
******/
BEGIN

	DECLARE SQL_Query Varchar(2000);
	DECLARE Exec bool;
	SET exec = false;

	SET SQL_Query = 'UPDATE productos set  '; 
	IF (I_idProducto is not null) THEN	 
		SET SQL_Query =  concat(SQL_Query,' idProducto= ''', I_idProducto ,''''); 
		SET exec =  True; 
	END IF;

	IF (I_valor is not null) THEN
		IF (Exec) THEN
			SET SQL_Query =  concat(SQL_Query,' , valor= ''',I_valor ,'''');
		ELSE
			SET SQL_Query =  concat(SQL_Query,' valor= ''',I_valor ,'''');
			SET exec =  True;
		END IF;  
	END IF;

	IF (I_presentacionProducto is not null) THEN
		IF (Exec) THEN
			SET SQL_Query =  concat(SQL_Query,' , presentacionProducto= ''',I_presentacionProducto ,'''');
		ELSE
			SET SQL_Query =  concat(SQL_Query,' presentacionProducto= ''', I_presentacionProducto ,'''');
			SET exec =  True;
		END IF;  
	END IF;

	IF (I_descripcion is not null) THEN
		IF (Exec) THEN
			SET SQL_Query =  concat(SQL_Query,' , descripcion= ''',I_descripcion ,'''');
		ELSE
			SET SQL_Query =  concat(SQL_Query,' descripcion= ''',I_descripcion ,'''');
			SET exec =  True;
		END IF;  
	END IF;

	IF (I_estadoProducto is not null) THEN
		IF (Exec) THEN
			SET SQL_Query =  concat(SQL_Query,' , estadoProducto= ''',I_estadoProducto ,'''');
		ELSE
			SET SQL_Query =  concat(SQL_Query,' estadoProducto= ''',I_estadoProducto ,'''');
			SET exec =  True;
		END IF; 
	END IF;

	Set SQL_Query = CONCAT( SQL_Query,' where idProducto= ? ');
	 
	IF (Exec) THEN 
		 SET @id_producto= I_idProducto;
		 set @aejecutar= SQL_Query; 
		 PREPARE SQL_QueryFinal FROM @aejecutar;  
		 EXECUTE SQL_QueryFinal using  @id_producto;
	END IF;

END$$


DELIMITER $$
CREATE PROCEDURE  LeerProducto ( I_idProducto int)
/****** 
Nombre: LeerProducto 
Autor: Sebastián Rave
Objetivo: Procedimiento que lee un producto de la base de datos de la tabla productos. 	
******/
BEGIN

	SELECT valor Precio, presentacionProducto Presentación, descripcion Descripcion, estadoProducto Estado
	FROM productos 
	WHERE idProducto = I_idProducto;
 
END $$

DELIMITER $$
CREATE FUNCTION UsuarioLoginContrasena (I_usuarioEmpleado varchar(50))
RETURNS VARCHAR(45)
DETERMINISTIC
/****** 
Nombre: UsuarioLoginContrasena 
Autor: Sebastián Rave
Objetivo: Función que lee el usuario de un empleado (usuario del correo), y retorna su contraseña.
******/
BEGIN

	DECLARE contrasena varchar(45);
    
	SELECT contrasenaEmpleado into contrasena
	FROM empleados 
	WHERE correoEmpleado= concat(I_usuarioEmpleado,'@mail.com');
    
    RETURN contrasena;

END $$

DELIMITER $$
CREATE FUNCTION UsuarioLoginEstado (I_usuarioEmpleado varchar(50))
RETURNS INT
DETERMINISTIC
/****** 
Nombre: UsuarioLoginContrasena 
Autor: Sebastián Rave
Objetivo: Función que lee el usuario de un empleado (usuario del correo), y retorna su estado.
******/
BEGIN

	DECLARE state varchar(45);
    
	SELECT estadoEmpleado into state
	FROM empleados 
	WHERE correoEmpleado= concat(I_usuarioEmpleado,'@mail.com');
    
    RETURN state;

END $$


DELIMITER $$
CREATE PROCEDURE  ActualizarEmpleado (
I_idEmpleado int, 
I_tipoDoc int, 
I_numeroDoc varchar(15), 
I_nombreEmpleado varchar(50), 
I_apellidoEmpleado varchar(50), 
I_correoEmpleado varchar(150),
I_telefonoEmpleado varchar(15),
I_contrasenaEmpleado varchar(45),
I_fechaContratacion date,
I_areaTrabajo int,
I_nivelEducativo int,
I_estadoEmpleado int
)
/****** 
Nombre: ActualizarEmpleado 
Autor: Sebastián Rave
Objetivo: Procedimiento que actualiza un empleado de la base de datos de la tabla empleados. 	
******/
BEGIN

	DECLARE SQL_Query Varchar(2000);
	DECLARE Exec bool;
	SET exec = false;

	SET SQL_Query = 'UPDATE empleados set  '; 
	IF (I_idEmpleado is not null) THEN	 
		SET SQL_Query =  concat(SQL_Query,' idEmpleado= ''', I_idEmpleado ,''''); 
		SET exec =  True; 
	END IF;

	IF (I_tipoDoc is not null) THEN
		IF (Exec) THEN
			SET SQL_Query =  concat(SQL_Query,' , tipoDoc= ''',I_tipoDoc ,'''');
		ELSE
			SET SQL_Query =  concat(SQL_Query,' tipoDoc= ''',I_tipoDoc ,'''');
			SET exec =  True;
		END IF;  
	END IF;

	IF (I_numeroDoc is not null) THEN
		IF (Exec) THEN
			SET SQL_Query =  concat(SQL_Query,' , numeroDoc= ''',I_numeroDoc ,'''');
		ELSE
			SET SQL_Query =  concat(SQL_Query,' numeroDoc= ''', I_numeroDoc ,'''');
			SET exec =  True;
		END IF;  
	END IF;

	IF (I_nombreEmpleado is not null) THEN
		IF (Exec) THEN
			SET SQL_Query =  concat(SQL_Query,' , nombreEmpleado= ''',I_nombreEmpleado ,'''');
		ELSE
			SET SQL_Query =  concat(SQL_Query,' nombreEmpleado= ''',I_nombreEmpleado ,'''');
			SET exec =  True;
		END IF;  
	END IF;

	IF (I_apellidoEmpleado is not null) THEN
		IF (Exec) THEN
			SET SQL_Query =  concat(SQL_Query,' , apellidoEmpleado= ''',I_apellidoEmpleado ,'''');
		ELSE
			SET SQL_Query =  concat(SQL_Query,' apellidoEmpleado= ''',I_apellidoEmpleado ,'''');
			SET exec =  True;
		END IF; 
	END IF;
    
    IF (I_correoEmpleado is not null) THEN
		IF (Exec) THEN
			SET SQL_Query =  concat(SQL_Query,' , correoEmpleado= ''',I_correoEmpleado ,'''');
		ELSE
			SET SQL_Query =  concat(SQL_Query,' correoEmpleado= ''',I_correoEmpleado ,'''');
			SET exec =  True;
		END IF;  
	END IF;
        
    IF (I_telefonoEmpleado is not null) THEN
		IF (Exec) THEN
			SET SQL_Query =  concat(SQL_Query,' , telefonoEmpleado= ''',I_telefonoEmpleado ,'''');
		ELSE
			SET SQL_Query =  concat(SQL_Query,' telefonoEmpleado= ''',I_telefonoEmpleado ,'''');
			SET exec =  True;
		END IF;  
	END IF;
    
    IF (I_contrasenaEmpleado is not null) THEN
		IF (Exec) THEN
			SET SQL_Query =  concat(SQL_Query,' , contrasenaEmpleado= ''',I_contrasenaEmpleado ,'''');
		ELSE
			SET SQL_Query =  concat(SQL_Query,' contrasenaEmpleado= ''',I_contrasenaEmpleado ,'''');
			SET exec =  True;
		END IF;  
	END IF;
    
    IF (I_fechaContratacion is not null) THEN
		IF (Exec) THEN
			SET SQL_Query =  concat(SQL_Query,' , fechaContratacion= ''',I_fechaContratacion ,'''');
		ELSE
			SET SQL_Query =  concat(SQL_Query,' fechaContratacion= ''',I_fechaContratacion ,'''');
			SET exec =  True;
		END IF;  
	END IF;
    
    IF (I_areaTrabajo is not null) THEN
		IF (Exec) THEN
			SET SQL_Query =  concat(SQL_Query,' , areaTrabajo= ''',I_areaTrabajo ,'''');
		ELSE
			SET SQL_Query =  concat(SQL_Query,' areaTrabajo= ''',I_areaTrabajo ,'''');
			SET exec =  True;
		END IF;  
	END IF;
    
    IF (I_nivelEducativo is not null) THEN
		IF (Exec) THEN
			SET SQL_Query =  concat(SQL_Query,' , nivelEducativo= ''',I_nivelEducativo ,'''');
		ELSE
			SET SQL_Query =  concat(SQL_Query,' nivelEducativo= ''',I_nivelEducativo ,'''');
			SET exec =  True;
		END IF;  
	END IF;
    
     IF (I_estadoEmpleado is not null) THEN
		IF (Exec) THEN
			SET SQL_Query =  concat(SQL_Query,' , estadoEmpleado= ''',I_estadoEmpleado ,'''');
		ELSE
			SET SQL_Query =  concat(SQL_Query,' estadoEmpleado= ''',I_estadoEmpleado ,'''');
			SET exec =  True;
		END IF;  
	END IF;
    
	Set SQL_Query = CONCAT( SQL_Query,' where idEmpleado= ? ');
	 
	IF (Exec) THEN 
		 SET @id_empleado= I_idEmpleado;
		 set @aejecutar= SQL_Query; 
		 PREPARE SQL_QueryFinal FROM @aejecutar;  
		 EXECUTE SQL_QueryFinal using  @id_empleado;
	END IF;

END$$


DELIMITER $$
CREATE PROCEDURE  LeerEmpleado ( I_idEmpleado int)
/****** 
Nombre: LeerEmpleado 
Autor: Sebastián Rave
Objetivo: Procedimiento que lee un empleado de la base de datos de la tabla empleados. 	
******/
BEGIN

	SELECT tipoDoc, numeroDoc, nombreEmpleado, apellidoEmpleado, correoEmpleado, telefonoEmpleado, fechaContratacion, areaTrabajo,
    nivelEducativo, estadoEmpleado
	FROM empleados 
	WHERE idEmpleado = I_idEmpleado;
 
END $$

