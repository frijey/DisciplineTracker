DROP procedure IF EXISTS `SListaCotizacionPorCod_cotOPorFec_cot`;
CREATE DEFINER=`root`@`%` PROCEDURE `SListaCotizacionPorCod_cotOPorFec_cot`(IN prm_parametro varchar(45))
BEGIN
SELECT 
cotizacion.*
FROM
cotizacion 
WHERE			
cotizacion.cod_cot LIKE prm_parametro OR cotizacion.fec_cot LIKE prm_parametro ORDER BY fec_cot;
END

DROP procedure IF EXISTS `SListaCotizacionPorSecuenciaDecod_cot`;

CREATE DEFINER=`root`@`%` PROCEDURE `SListaCotizacionPorSecuenciaDecod_cot`(IN prm_tiposecuencia varchar(5), IN prm_idactual int(11))
BEGIN
#Nota: P = primero, A = anterior, S = siguiente y U = último...
if (upper(prm_tiposecuencia) = "P") then

SELECT * FROM cotizacion WHERE cod_cot = (select min(cod_cot) from cotizacion);

elseif(upper(prm_tiposecuencia) = "A")then

SELECT * FROM cotizacion WHERE cod_cot < prm_idactual ORDER BY cod_cot DESC LIMIT 1;

elseif(upper(prm_tiposecuencia) = "S")then

SELECT * FROM cotizacion WHERE cod_cot > prm_idactual ORDER BY cod_cot LIMIT 1;

elseif(upper(prm_tiposecuencia) = "U")then

SELECT * FROM cotizacion WHERE cod_cot = (select max(cod_cot) from cotizacion);

end if;

END

DROP procedure IF EXISTS `SCotizacion`;

CREATE DEFINER=`root`@`%` PROCEDURE `SCotizacion`(IN prm_id int(11))
BEGIN
	SELECT 
		*
	FROM
		cotizacion 
	WHERE			
		cotizacion.cod_cot = prm_id;
END



CREATE DEFINER =`root`@`%` PROCEDURE `SentenciaCotizacion`(accion varchar(5), prm_cod_cot int(11), prm_fec_cot date, prm_hor_cot time, prm_tip_cot varchar(45), prm_fk_cod_cli int(11), prm_sub_tot_cot decimal(12,2), prm_itb_cot decimal(12,2), prm_des_cot decimal(12,2), prm_tot_cot decimal(12,2))
BEGIN

if (upper(accion) = "I") then

insert into cotizacion(fec_cot, hor_cot, tip_cot, fk_cod_cli, sub_tot_cot, itb_cot, des_cot, tot_cot) values(prm_fec_cot, prm_hor_cot, prm_tip_cot, prm_fk_cod_cli, prm_sub_tot_cot, prm_itb_cot, prm_des_cot, prm_tot_cot);

elseif(upper(accion) = "U")then

update cotizacion set fec_cot = prm_fec_cot, hor_cot = prm_hor_cot, tip_cot = prm_tip_cot, fk_cod_cli = prm_fk_cod_cli, sub_tot_cot = prm_sub_tot_cot, itb_cot = prm_itb_cot, des_cot = prm_des_cot, tot_cot = prm_tot_cot where cod_cot = prm_cod_cot;

elseif(upper(accion) = "D")then

delete from cotizacion where cod_cot = prm_cod_cot;

end if;
select last_insert_id();

END