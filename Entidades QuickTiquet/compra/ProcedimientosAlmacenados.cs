DROP procedure IF EXISTS `SListaCompraPorCod_comOPorFec_com`;
CREATE DEFINER=`root`@`%` PROCEDURE `SListaCompraPorCod_comOPorFec_com`(IN prm_parametro varchar(45))
BEGIN
SELECT 
compra.*
FROM
compra 
WHERE			
compra.cod_com LIKE prm_parametro OR compra.fec_com LIKE prm_parametro ORDER BY fec_com;
END

DROP procedure IF EXISTS `SListaCompraPorSecuenciaDecod_com`;

CREATE DEFINER=`root`@`%` PROCEDURE `SListaCompraPorSecuenciaDecod_com`(IN prm_tiposecuencia varchar(5), IN prm_idactual int(11))
BEGIN
#Nota: P = primero, A = anterior, S = siguiente y U = último...
if (upper(prm_tiposecuencia) = "P") then

SELECT * FROM compra WHERE cod_com = (select min(cod_com) from compra);

elseif(upper(prm_tiposecuencia) = "A")then

SELECT * FROM compra WHERE cod_com < prm_idactual ORDER BY cod_com DESC LIMIT 1;

elseif(upper(prm_tiposecuencia) = "S")then

SELECT * FROM compra WHERE cod_com > prm_idactual ORDER BY cod_com LIMIT 1;

elseif(upper(prm_tiposecuencia) = "U")then

SELECT * FROM compra WHERE cod_com = (select max(cod_com) from compra);

end if;

END

DROP procedure IF EXISTS `SCompra`;

CREATE DEFINER=`root`@`%` PROCEDURE `SCompra`(IN prm_id int(11))
BEGIN
	SELECT 
		*
	FROM
		compra 
	WHERE			
		compra.cod_com = prm_id;
END



CREATE DEFINER =`root`@`%` PROCEDURE `SentenciaCompra`(accion varchar(5), prm_cod_com int(11), prm_fec_com date, prm_hor_com time, prm_tip_com varchar(45), prm_fk_cod_pro int(11), prm_sub_tot_com decimal(12,2), prm_itb_com decimal(12,2), prm_des_com decimal(12,2), prm_tot_com decimal(12,2))
BEGIN

if (upper(accion) = "I") then

insert into compra(fec_com, hor_com, tip_com, fk_cod_pro, sub_tot_com, itb_com, des_com, tot_com) values(prm_fec_com, prm_hor_com, prm_tip_com, prm_fk_cod_pro, prm_sub_tot_com, prm_itb_com, prm_des_com, prm_tot_com);

elseif(upper(accion) = "U")then

update compra set fec_com = prm_fec_com, hor_com = prm_hor_com, tip_com = prm_tip_com, fk_cod_pro = prm_fk_cod_pro, sub_tot_com = prm_sub_tot_com, itb_com = prm_itb_com, des_com = prm_des_com, tot_com = prm_tot_com where cod_com = prm_cod_com;

elseif(upper(accion) = "D")then

delete from compra where cod_com = prm_cod_com;

end if;
select last_insert_id();

END