
CREATE TABLE cadastro (
    id SERIAL PRIMARY KEY,
    nome TEXT NOT NULL,
    cpf BIGINT NOT NULL UNIQUE CHECK (cpf > 0)
);


CREATE TABLE log_operacoes (
    id SERIAL PRIMARY KEY,
    data_hora TIMESTAMP NOT NULL DEFAULT NOW(),
    operacao TEXT NOT NULL,
    id_alterado INTEGER NOT NULL
);


CREATE OR REPLACE FUNCTION log_operacao()
RETURNS TRIGGER AS $$
BEGIN
    IF TG_OP = 'DELETE' THEN
        INSERT INTO log_operacoes (operacao, id_alterado)
        VALUES (TG_OP, OLD.id);
        RETURN OLD;
    ELSE
        INSERT INTO log_operacoes (operacao, id_alterado)
        VALUES (TG_OP, NEW.id);
        RETURN NEW;
    END IF;
END;
$$ LANGUAGE plpgsql;


CREATE TRIGGER trg_audit_cadastro
AFTER INSERT OR UPDATE OR DELETE ON cadastro
FOR EACH ROW
EXECUTE FUNCTION log_operacao();	


INSERT INTO cadastro (nome, cpf) VALUES ('João', 12345678901);
UPDATE cadastro SET nome = 'João' WHERE cpf = 12345678901;
DELETE FROM cadastro WHERE cpf = 12345678901;

SELECT * FROM log_operacoes;