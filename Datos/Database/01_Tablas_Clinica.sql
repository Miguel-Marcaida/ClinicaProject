DROP DATABASE IF EXISTS clinica_db;
CREATE DATABASE clinica_db;
USE clinica_db;

-- 1. CONFIGURACIÓN BÁSICA
CREATE TABLE roles (
    id_rol INT AUTO_INCREMENT PRIMARY KEY,
    nombre_rol VARCHAR(50) NOT NULL UNIQUE
);

CREATE TABLE especialidades (
    id_especialidad INT AUTO_INCREMENT PRIMARY KEY,
    nombre VARCHAR(100) NOT NULL,
    duracion_base_min INT NOT NULL DEFAULT 15
);

CREATE TABLE obras_sociales (
    id_os INT AUTO_INCREMENT PRIMARY KEY,
    nombre VARCHAR(100) NOT NULL UNIQUE
);

CREATE TABLE consultorios (
    id_consultorio INT AUTO_INCREMENT PRIMARY KEY,
    nombre_nro VARCHAR(50) NOT NULL,
    tipo_consultorio ENUM('General', 'Kinesiologia', 'Laboratorio', 'Salud Mental')
);

-- 2. IDENTIDAD Y SEGURIDAD
CREATE TABLE personas (
    id_persona INT AUTO_INCREMENT PRIMARY KEY,
    dni VARCHAR(20) NOT NULL UNIQUE,
    nombre VARCHAR(100) NOT NULL,
    apellido VARCHAR(100) NOT NULL,
    telefono VARCHAR(20),
    email VARCHAR(100),
    fecha_nacimiento DATE
);

CREATE TABLE usuarios (
    id_usuario INT AUTO_INCREMENT PRIMARY KEY,
    id_persona INT NOT NULL,
    username VARCHAR(50) NOT NULL UNIQUE,
    password_hash VARCHAR(255) NOT NULL,
    id_rol INT NOT NULL,
    activo BOOLEAN DEFAULT TRUE,
    CONSTRAINT fk_usuario_persona FOREIGN KEY (id_persona) REFERENCES personas(id_persona),
    CONSTRAINT fk_usuario_rol FOREIGN KEY (id_rol) REFERENCES roles(id_rol)
);

-- 3. PERFILES MÉDICOS Y PACIENTES
CREATE TABLE pacientes (
    id_paciente INT PRIMARY KEY,
    nro_empadronamiento VARCHAR(20) UNIQUE,
    id_os INT,
    plan_os VARCHAR(50),
    nro_afiliado VARCHAR(50),
    CONSTRAINT fk_paciente_persona FOREIGN KEY (id_paciente) REFERENCES personas(id_persona),
    CONSTRAINT fk_paciente_os FOREIGN KEY (id_os) REFERENCES obras_sociales(id_os)
);

CREATE TABLE medicos (
    id_medico INT PRIMARY KEY,
    matricula VARCHAR(50) UNIQUE,
    CONSTRAINT fk_medico_persona FOREIGN KEY (id_medico) REFERENCES personas(id_persona)
);

CREATE TABLE medico_especialidad (
    id_medico INT,
    id_especialidad INT,
    PRIMARY KEY (id_medico, id_especialidad),
    CONSTRAINT fk_me_medico FOREIGN KEY (id_medico) REFERENCES medicos(id_medico),
    CONSTRAINT fk_me_especialidad FOREIGN KEY (id_especialidad) REFERENCES especialidades(id_especialidad)
);

-- 4. GESTIÓN DE ATENCIÓN Y AGENDAS
CREATE TABLE agenda_config (
    id_config INT AUTO_INCREMENT PRIMARY KEY,
    id_medico INT NOT NULL,
    dia_semana ENUM('Lunes', 'Martes', 'Miercoles', 'Jueves', 'Viernes', 'Sabado'),
    hora_inicio TIME NOT NULL,
    hora_fin TIME NOT NULL,
    id_consultorio INT,
    CONSTRAINT fk_agenda_medico FOREIGN KEY (id_medico) REFERENCES medicos(id_medico),
    CONSTRAINT fk_agenda_cons FOREIGN KEY (id_consultorio) REFERENCES consultorios(id_consultorio)
);

CREATE TABLE turnos (
    id_turno INT AUTO_INCREMENT PRIMARY KEY,
    fecha_hora DATETIME NOT NULL,
    id_paciente INT NOT NULL,
    id_medico INT NOT NULL,
    id_usuario_alta INT NOT NULL,
    id_consultorio INT,
    estado ENUM('Pendiente', 'Acreditado', 'En Espera', 'En Consultorio', 'Finalizado', 'Cancelado') DEFAULT 'Pendiente',
    tipo_atencion ENUM('Consulta', 'Estudio', 'Laboratorio') DEFAULT 'Consulta',
    es_sobreturno BOOLEAN DEFAULT FALSE,
    observaciones TEXT,
    CONSTRAINT fk_turno_paciente FOREIGN KEY (id_paciente) REFERENCES pacientes(id_paciente),
    CONSTRAINT fk_turno_medico FOREIGN KEY (id_medico) REFERENCES medicos(id_medico),
    CONSTRAINT fk_turno_usuario FOREIGN KEY (id_usuario_alta) REFERENCES usuarios(id_usuario),
    CONSTRAINT fk_turno_cons FOREIGN KEY (id_consultorio) REFERENCES consultorios(id_consultorio)
);

-- 5. ESTUDIOS E INVENTARIO
CREATE TABLE estudios (
    id_estudio INT AUTO_INCREMENT PRIMARY KEY,
    nombre_estudio VARCHAR(100) NOT NULL,
    requiere_ayuno BOOLEAN DEFAULT FALSE,
    id_especialidad INT,
    CONSTRAINT fk_estudio_esp FOREIGN KEY (id_especialidad) REFERENCES especialidades(id_especialidad)
);

CREATE TABLE insumos (
    id_insumo INT AUTO_INCREMENT PRIMARY KEY,
    nombre VARCHAR(100) NOT NULL,
    stock_actual INT DEFAULT 0,
    stock_minimo INT DEFAULT 10
);

-- 6. SEGURIDAD Y TRAZABILIDAD
CREATE TABLE auditoria (
    id_log INT AUTO_INCREMENT PRIMARY KEY,
    id_usuario INT,
    fecha_hora TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    modulo VARCHAR(50),
    operacion VARCHAR(20),
    detalle TEXT,
    CONSTRAINT fk_audi_user FOREIGN KEY (id_usuario) REFERENCES usuarios(id_usuario)
);


