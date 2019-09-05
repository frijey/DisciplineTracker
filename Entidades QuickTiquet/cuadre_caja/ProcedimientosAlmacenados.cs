DROP procedure IF EXISTS `SListaCuadre_cajaPorCod_cua_cajOPorFk_usu_cua_caj`;
CREATE DEFINER=`root`@`%` PROCEDURE `SListaCuadre_cajaPorCod_cua_cajOPorFk_usu_cua_caj`(IN prm_parametro varchar(45))
BEGIN
SELECT 
cuadre_caja.*
FROM
cuadre_caja 
WHERE			
cuadre_caja.cod_cua_caj LIKE prm_parametro OR cuadre_caja.fk_usu_cua_caj LIKE prm_parametro ORDER BY fk_usu_cua_caj;
END

DROP procedure IF EXISTS `SListaCuadre_cajaPorSecuenciaDecod_cua_caj`;

CREATE DEFINER=`root`@`%` PROCEDURE `SListaCuadre_cajaPorSecuenciaDecod_cua_caj`(IN prm_tiposecuencia varchar(5), IN prm_idactual int(11))
BEGIN
#Nota: P = primero, A = anterior, S = siguiente y U = último...
if (upper(prm_tiposecuencia) = "P") then

SELECT * FROM cuadre_caja WHERE cod_cua_caj = (select min(cod_cua_caj) from cuadre_caja);

elseif(upper(prm_tiposecuencia) = "A")then

SELECT * FROM cuadre_caja WHERE cod_cua_caj < prm_idactual ORDER BY cod_cua_caj DESC LIMIT 1;

elseif(upper(prm_tiposecuencia) = "S")then

SELECT * FROM cuadre_caja WHERE cod_cua_caj > prm_idactual ORDER BY cod_cua_caj LIMIT 1;

elseif(upper(prm_tiposecuencia) = "U")then

SELECT * FROM cuadre_caja WHERE cod_cua_caj = (select max(cod_cua_caj) from cuadre_caja);

end if;

END

DROP procedure IF EXISTS `SCuadre_caja`;

CREATE DEFINER=`root`@`%` PROCEDURE `SCuadre_caja`(IN prm_id int(11))
BEGIN
	SELECT 
		*
	FROM
		cuadre_caja 
	WHERE			
		cuadre_caja.cod_cua_caj = prm_id;
END



CREATE DEFINER =`root`@`%` PROCEDURE `SentenciaCuadre_caja`(accion varchar(5), prm_cod_cua_caj int(11), prm_fk_usu_cua_caj int(11), prm_fec_cua_caj date, prm_hor_cua_caj time, prm_tot_cua_caj decimal(12,2))
BEGIN

if (upper(accion) = "I") then

insert into cuadre_caja(fk_usu_cua_caj, fec_cua_caj, hor_cua_caj, tot_cua_caj) values(prm_fk_usu_cua_caj, prm_fec_cua_caj, prm_hor_cua_caj, prm_tot_cua_caj);

elseif(upper(accion) = "U")then

update cuadre_caja set fk_usu_cua_caj = prm_fk_usu_cua_caj, fec_cua_caj = prm_fec_cua_caj, hor_cua_caj = prm_hor_cua_caj, tot_cua_caj = prm_tot_cua_caj where cod_cua_caj = prm_cod_cua_caj;

elseif(upper(accion) = "D")then

delete from cuadre_caja where cod_cua_caj = prm_cod_cua_caj;

end if;
select last_insert_id();

END