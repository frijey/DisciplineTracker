DROP procedure IF EXISTS `SListaDetalle_compraPorFk_cod_comOPorFk_cod_art`;
CREATE DEFINER=`root`@`%` PROCEDURE `SListaDetalle_compraPorFk_cod_comOPorFk_cod_art`(IN prm_parametro varchar(45))
BEGIN
SELECT 
detalle_compra.*
FROM
detalle_compra 
WHERE			
detalle_compra.fk_cod_com LIKE prm_parametro OR detalle_compra.fk_cod_art LIKE prm_parametro ORDER BY fk_cod_art;
END

DROP procedure IF EXISTS `SListaDetalle_compraPorSecuenciaDefk_cod_com`;

CREATE DEFINER=`root`@`%` PROCEDURE `SListaDetalle_compraPorSecuenciaDefk_cod_com`(IN prm_tiposecuencia varchar(5), IN prm_idactual int(11))
BEGIN
#Nota: P = primero, A = anterior, S = siguiente y U = último...
if (upper(prm_tiposecuencia) = "P") then

SELECT * FROM detalle_compra WHERE fk_cod_com = (select min(fk_cod_com) from detalle_compra);

elseif(upper(prm_tiposecuencia) = "A")then

SELECT * FROM detalle_compra WHERE fk_cod_com < prm_idactual ORDER BY fk_cod_com DESC LIMIT 1;

elseif(upper(prm_tiposecuencia) = "S")then

SELECT * FROM detalle_compra WHERE fk_cod_com > prm_idactual ORDER BY fk_cod_com LIMIT 1;

elseif(upper(prm_tiposecuencia) = "U")then

SELECT * FROM detalle_compra WHERE fk_cod_com = (select max(fk_cod_com) from detalle_compra);

end if;

END

DROP procedure IF EXISTS `SDetalle_compra`;

CREATE DEFINER=`root`@`%` PROCEDURE `SDetalle_compra`(IN prm_id int(11))
BEGIN
	SELECT 
		*
	FROM
		detalle_compra 
	WHERE			
		detalle_compra.fk_cod_com = prm_id;
END



CREATE DEFINER =`root`@`%` PROCEDURE `SentenciaDetalle_compra`(accion varchar(5), prm_fk_cod_com int(11), prm_fk_cod_art int(11), prm_nom_det_com varchar(65), prm_can_det_com decimal(12,2), prm_sub_tot_det_com decimal(12,2))
BEGIN

if (upper(accion) = "I") then

insert into detalle_compra(fk_cod_art, nom_det_com, can_det_com, sub_tot_det_com) values(prm_fk_cod_art, prm_nom_det_com, prm_can_det_com, prm_sub_tot_det_com);

elseif(upper(accion) = "U")then

update detalle_compra set fk_cod_art = prm_fk_cod_art, nom_det_com = prm_nom_det_com, can_det_com = prm_can_det_com, sub_tot_det_com = prm_sub_tot_det_com where fk_cod_com = prm_fk_cod_com;

elseif(upper(accion) = "D")then

delete from detalle_compra where fk_cod_com = prm_fk_cod_com;

end if;
select last_insert_id();

END