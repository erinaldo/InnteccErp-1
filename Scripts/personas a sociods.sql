INSERT INTO
  inntecc.socionegocio
(
  idpersona,
  idtiposocio,
  codigosocio,
  fecharegistro,
  nrodocentidad,
  idtipocondicion,
  idtipolista,
  esagenteretenedor,
  esactivo,
  pordescuentototal,
  comentario,
  incluyeimpuestoitems,
  sujetoadetraccion,
  fechafundacion,
  paginaweb,
  fechaaniversario,
  idrubronegocio,
  idgrupoeconomico,
  idcategoriaproveedor,
  esagentepercepcion,
  idzona,
  secuenciareparto,
  diavisitasemana,
  frecuenciavisita,
  idestadosocionegocio,
  iniciosuspension,
  finsuspension,
  motivosuspension,
  idvendedor,
  idempresa
)
SELECT
  inntecc.persona.idpersona,
  inntecc.socionegocio.idtiposocio,
  inntecc.socionegocio.codigosocio,
  inntecc.socionegocio.fecharegistro,
  inntecc.socionegocio.nrodocentidad,
  inntecc.socionegocio.idtipocondicion,
  inntecc.socionegocio.idtipolista,
  inntecc.socionegocio.esagenteretenedor,
  inntecc.socionegocio.esactivo,
  inntecc.socionegocio.pordescuentototal,
  inntecc.socionegocio.comentario,
  inntecc.socionegocio.incluyeimpuestoitems,
  inntecc.socionegocio.sujetoadetraccion,
  inntecc.socionegocio.fechafundacion,
  inntecc.socionegocio.paginaweb,
  inntecc.socionegocio.fechaaniversario,
  inntecc.socionegocio.idrubronegocio,
  inntecc.socionegocio.idgrupoeconomico,
  inntecc.socionegocio.idcategoriaproveedor,
  inntecc.socionegocio.esagentepercepcion,
  inntecc.socionegocio.idzona,
  inntecc.socionegocio.secuenciareparto,
  inntecc.socionegocio.diavisitasemana,
  inntecc.socionegocio.frecuenciavisita,
  inntecc.socionegocio.idestadosocionegocio,
  inntecc.socionegocio.iniciosuspension,
  inntecc.socionegocio.finsuspension,
  inntecc.socionegocio.motivosuspension,
  inntecc.socionegocio.idvendedor,
  inntecc.socionegocio.idempresa
FROM
  inntecc.socionegocio,
  inntecc.persona
WHERE
  inntecc.socionegocio.idsocionegocio = 2055 AND
  inntecc.persona.idpersona NOT IN (SELECT a.idpersona FROM inntecc.socionegocio a)

INSERT INTO
  inntecc.socionegociodireccion
(

  idsocionegocio,
  iddistrito,
  direccionsocionegocio,
  referencia,
  principal,
  idpais,
  tipolocal
)


select a.idsocionegocio,b.iddistrito, b.direccionfiscal,'',true,b.idpais,''
from inntecc.socionegocio a
left join inntecc.persona b on a.idpersona = b.idpersona
where a.idsocionegocio NOT IN (select a.idsocionegocio from inntecc.socionegociodireccion a)