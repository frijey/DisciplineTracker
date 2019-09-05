DROP procedure IF EXISTS `SListaDetalle_cuadre_cajaPorFk_cua_cajOPorFk_cod_fac`;
CREATE DEFINER=`root`@`%` PROCEDURE `SListaDetalle_cuadre_cajaPorFk_cua_cajOPorFk_cod_fac`(IN prm_parametro varchar(45))
BEGIN
SELECT 
detalle_cuadre_caja.*
FROM
detalle_cuadre_caja 
WHERE			
detalle_cuadre_caja.fk_cua_caj LIKE prm_parametro OR detalle_cuadre_caja.fk_cod_fac LIKE prm_parametro ORDER BY fk_cod_fac;
END

DROP procedure IF EXISTS `SDetalle_cuadre_caja`;

CREATE DEFINER=`root`@`%` PROCEDURE `SDetalle_cuadre_caja`(IN prm_id int(11))
BEGIN
	SELECT 
		*
	FROM
		detalle_cuadre_caja 
	WHERE			
		detalle_cuadre_caja.fk_cua_caj = prm_id;
END



CREATE DEFINER =`root`@`%` PROCEDURE `SentenciaDetalle_cuadre_caja`(accion varchar(5), prm_fk_cua_caj int(11), prm_fk_cod_fac int(11), prm_fec_det_cua_caj date, prm_hor_det_cua_caj time, prm_tot_det_cua_caj decimal(12,2))
BEGIN

if (upper(accion) = "I") then

insert into detalle_cuadre_caja(fk_cod_fac, fec_det_cua_caj, hor_det_cua_caj, tot_det_cua_caj) values(prm_fk_cod_fac, prm_fec_det_cua_caj, prm_hor_det_cua_caj, prm_tot_det_cua_caj);

elseif(upper(accion) = "U")then

update detalle_cuadre_caja set fk_cod_fac = prm_fk_cod_fac, fec_det_cua_caj = prm_fec_det_cua_caj, hor_det_cua_caj = prm_hor_det_cua_caj, tot_det_cua_caj = prm_tot_det_cua_caj where fk_cua_caj = prm_fk_cua_caj;

elseif(upper(accion) = "D")then

delete from detalle_cuadre_caja where fk_cua_caj = prm_fk_cua_caj;

end if;
select last_insert_id();

END