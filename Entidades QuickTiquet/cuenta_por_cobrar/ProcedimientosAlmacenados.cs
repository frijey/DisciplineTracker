DROP procedure IF EXISTS `SListaCuenta_por_cobrarPorFk_cod_cliOPorFk_cod_fac`;
CREATE DEFINER=`root`@`%` PROCEDURE `SListaCuenta_por_cobrarPorFk_cod_cliOPorFk_cod_fac`(IN prm_parametro varchar(45))
BEGIN
SELECT 
cuenta_por_cobrar.*
FROM
cuenta_por_cobrar 
WHERE			
cuenta_por_cobrar.fk_cod_cli LIKE prm_parametro OR cuenta_por_cobrar.fk_cod_fac LIKE prm_parametro ORDER BY fk_cod_fac;
END

DROP procedure IF EXISTS `SListaCuenta_por_cobrarPorSecuenciaDefk_cod_cli`;

CREATE DEFINER=`root`@`%` PROCEDURE `SListaCuenta_por_cobrarPorSecuenciaDefk_cod_cli`(IN prm_tiposecuencia varchar(5), IN prm_idactual int(11))
BEGIN
#Nota: P = primero, A = anterior, S = siguiente y U = último...
if (upper(prm_tiposecuencia) = "P") then

SELECT * FROM cuenta_por_cobrar WHERE fk_cod_cli = (select min(fk_cod_cli) from cuenta_por_cobrar);

elseif(upper(prm_tiposecuencia) = "A")then

SELECT * FROM cuenta_por_cobrar WHERE fk_cod_cli < prm_idactual ORDER BY fk_cod_cli DESC LIMIT 1;

elseif(upper(prm_tiposecuencia) = "S")then

SELECT * FROM cuenta_por_cobrar WHERE fk_cod_cli > prm_idactual ORDER BY fk_cod_cli LIMIT 1;

elseif(upper(prm_tiposecuencia) = "U")then

SELECT * FROM cuenta_por_cobrar WHERE fk_cod_cli = (select max(fk_cod_cli) from cuenta_por_cobrar);

end if;

END

DROP procedure IF EXISTS `SCuenta_por_cobrar`;

CREATE DEFINER=`root`@`%` PROCEDURE `SCuenta_por_cobrar`(IN prm_id int(11))
BEGIN
	SELECT 
		*
	FROM
		cuenta_por_cobrar 
	WHERE			
		cuenta_por_cobrar.fk_cod_cli = prm_id;
END



CREATE DEFINER =`root`@`%` PROCEDURE `SentenciaCuenta_por_cobrar`(accion varchar(5), prm_fk_cod_cli int(11), prm_fk_cod_fac int(11), prm_bal_cue_por_cob decimal(12,2), prm_obs_cue_por_cob varchar(100))
BEGIN

if (upper(accion) = "I") then

insert into cuenta_por_cobrar(fk_cod_fac, bal_cue_por_cob, obs_cue_por_cob) values(prm_fk_cod_fac, prm_bal_cue_por_cob, prm_obs_cue_por_cob);

elseif(upper(accion) = "U")then

update cuenta_por_cobrar set fk_cod_fac = prm_fk_cod_fac, bal_cue_por_cob = prm_bal_cue_por_cob, obs_cue_por_cob = prm_obs_cue_por_cob where fk_cod_cli = prm_fk_cod_cli;

elseif(upper(accion) = "D")then

delete from cuenta_por_cobrar where fk_cod_cli = prm_fk_cod_cli;

end if;
select last_insert_id();

END