DROP procedure IF EXISTS `SListaArticuloPorCod_artOPorNom_art`;
CREATE DEFINER=`root`@`%` PROCEDURE `SListaArticuloPorCod_artOPorNom_art`(IN prm_parametro varchar(45))
BEGIN
SELECT 
articulo.*
FROM
articulo 
WHERE			
articulo.cod_art LIKE prm_parametro OR articulo.nom_art LIKE prm_parametro ORDER BY nom_art;
END

DROP procedure IF EXISTS `SListaArticuloPorSecuenciaDecod_art`;

CREATE DEFINER=`root`@`%` PROCEDURE `SListaArticuloPorSecuenciaDecod_art`(IN prm_tiposecuencia varchar(5), IN prm_idactual int(11))
BEGIN
#Nota: P = primero, A = anterior, S = siguiente y U = último...
if (upper(prm_tiposecuencia) = "P") then

SELECT * FROM articulo WHERE cod_art = (select min(cod_art) from articulo);

elseif(upper(prm_tiposecuencia) = "A")then

SELECT * FROM articulo WHERE cod_art < prm_idactual ORDER BY cod_art DESC LIMIT 1;

elseif(upper(prm_tiposecuencia) = "S")then

SELECT * FROM articulo WHERE cod_art > prm_idactual ORDER BY cod_art LIMIT 1;

elseif(upper(prm_tiposecuencia) = "U")then

SELECT * FROM articulo WHERE cod_art = (select max(cod_art) from articulo);

end if;

END

DROP procedure IF EXISTS `SArticulo`;

CREATE DEFINER=`root`@`%` PROCEDURE `SArticulo`(IN prm_id int(11))
BEGIN
	SELECT 
		*
	FROM
		articulo 
	WHERE			
		articulo.cod_art = prm_id;
END



CREATE DEFINER =`root`@`%` PROCEDURE `SentenciaArticulo`(accion varchar(5), prm_cod_art int(11), prm_nom_art varchar(45), prm_des_art varchar(45), prm_mar_art varchar(45), prm_cost_art decimal(12,2), prm_prec_art decimal(12,2), prm_exis_art decimal(12,2), prm_cant_min_art decimal(12,2))
BEGIN

if (upper(accion) = "I") then

insert into articulo(nom_art, des_art, mar_art, cost_art, prec_art, exis_art, cant_min_art) values(prm_nom_art, prm_des_art, prm_mar_art, prm_cost_art, prm_prec_art, prm_exis_art, prm_cant_min_art);

elseif(upper(accion) = "U")then

update articulo set nom_art = prm_nom_art, des_art = prm_des_art, mar_art = prm_mar_art, cost_art = prm_cost_art, prec_art = prm_prec_art, exis_art = prm_exis_art, cant_min_art = prm_cant_min_art where cod_art = prm_cod_art;

elseif(upper(accion) = "D")then

delete from articulo where cod_art = prm_cod_art;

end if;
select last_insert_id();

END