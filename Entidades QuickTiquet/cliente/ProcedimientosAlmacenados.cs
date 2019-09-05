DROP procedure IF EXISTS `SListaClientePorCod_cliOPorNom_cli`;
CREATE DEFINER=`root`@`%` PROCEDURE `SListaClientePorCod_cliOPorNom_cli`(IN prm_parametro varchar(45))
BEGIN
SELECT 
cliente.*
FROM
cliente 
WHERE			
cliente.cod_cli LIKE prm_parametro OR cliente.nom_cli LIKE prm_parametro ORDER BY nom_cli;
END

DROP procedure IF EXISTS `SListaClientePorSecuenciaDecod_cli`;

CREATE DEFINER=`root`@`%` PROCEDURE `SListaClientePorSecuenciaDecod_cli`(IN prm_tiposecuencia varchar(5), IN prm_idactual int(11))
BEGIN
#Nota: P = primero, A = anterior, S = siguiente y U = último...
if (upper(prm_tiposecuencia) = "P") then

SELECT * FROM cliente WHERE cod_cli = (select min(cod_cli) from cliente);

elseif(upper(prm_tiposecuencia) = "A")then

SELECT * FROM cliente WHERE cod_cli < prm_idactual ORDER BY cod_cli DESC LIMIT 1;

elseif(upper(prm_tiposecuencia) = "S")then

SELECT * FROM cliente WHERE cod_cli > prm_idactual ORDER BY cod_cli LIMIT 1;

elseif(upper(prm_tiposecuencia) = "U")then

SELECT * FROM cliente WHERE cod_cli = (select max(cod_cli) from cliente);

end if;

END

DROP procedure IF EXISTS `SCliente`;

CREATE DEFINER=`root`@`%` PROCEDURE `SCliente`(IN prm_id int(11))
BEGIN
	SELECT 
		*
	FROM
		cliente 
	WHERE			
		cliente.cod_cli = prm_id;
END



CREATE DEFINER =`root`@`%` PROCEDURE `SentenciaCliente`(accion varchar(5), prm_cod_cli int(11), prm_nom_cli varchar(45), prm_ape_cli varchar(45), prm_sex_cli varchar(15), prm_dir_cli varchar(245), prm_sec_cli varchar(45), prm_zon_cli varchar(45), prm_cel_cli varchar(15), prm_ema_cli varchar(45), prm_ced_cli varchar(15))
BEGIN

if (upper(accion) = "I") then

insert into cliente(nom_cli, ape_cli, sex_cli, dir_cli, sec_cli, zon_cli, cel_cli, ema_cli, ced_cli) values(prm_nom_cli, prm_ape_cli, prm_sex_cli, prm_dir_cli, prm_sec_cli, prm_zon_cli, prm_cel_cli, prm_ema_cli, prm_ced_cli);

elseif(upper(accion) = "U")then

update cliente set nom_cli = prm_nom_cli, ape_cli = prm_ape_cli, sex_cli = prm_sex_cli, dir_cli = prm_dir_cli, sec_cli = prm_sec_cli, zon_cli = prm_zon_cli, cel_cli = prm_cel_cli, ema_cli = prm_ema_cli, ced_cli = prm_ced_cli where cod_cli = prm_cod_cli;

elseif(upper(accion) = "D")then

delete from cliente where cod_cli = prm_cod_cli;

end if;
select last_insert_id();

END