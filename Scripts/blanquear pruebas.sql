delete from almacen.entradaalmacenobs;
delete from almacen.entradaalmacendet;

delete from almacen.entradaalmacen;
delete from almacen.salidaalmacendet;
delete from almacen.salidaalmacen;

delete from compras.notacreditodet;
delete from compras.notacredito;

delete from compras.notadebitodet;
delete from compras.notadebito;

delete from finanzas.rendicioncajachicadet;
delete from finanzas.rendicioncajachica;


delete from compras.cpcompradet;
delete from compras.cpcompra;
delete from compras.ordencompradet;
delete from compras.ordencompra;

delete from almacen.guiaremisiondetimpcpventadet;
delete from almacen.guiaremisiondet;
delete from almacen.guiaremision;


delete from compras.cuadrocomparativoarticulo;
delete from compras.cuadrocomparativoprv;
delete from compras.cuadrocomparativo;

delete from compras.cotizacionprvdet;
delete from compras.cotizacionprv;

delete from compras.ordencompradet;
delete from compras.ordencompra;

delete from finanzas.recibocajaingresodet;
delete from finanzas.recibocajaingreso;


delete from ventas.cpventadet;
delete from ventas.cpventa;

delete from maquinaria.valorizacionegreso;
delete from maquinaria.valorizaciondet;
delete from maquinaria.valorizacion;

delete from maquinaria.valorizacionegresoproveedor;
delete from maquinaria.valorizacionproveedordet;
delete from maquinaria.valorizacionproveedor;

delete from compras.ordenserviciodet;
delete from compras.ordenservicio;


delete from compras.requerimientodet;
delete from compras.requerimiento;

delete from almacen.inventariostock;
delete from almacen.inventarioubicacion;
delete from almacen.inventario;

update  inntecc.articulo set idequipo = null;

delete from inntecc.articuloubicacion;
delete from inntecc.articulodetalleunidad;

delete from ventas.ordendeventadet;
delete from ventas.ordendeventa;

delete from ventas.cotizacionclientedet;
delete from ventas.cotizacioncliente;



delete from clinica.programacioncitadet;
delete from clinica.programacioncita;
delete from almacen.inventariostock;
delete from inntecc.articuloubicacion;
delete from inntecc.articulo;


delete from  maquinaria.mantenimientoimagen;
delete from  maquinaria.mantenimiento;


delete from maquinaria.equipo;


delete from finanzas.recibocajaegresodet;
delete from finanzas.recibocajaegreso;



delete from clinica.historiadetitem;
delete from clinica.historiadet;
delete from clinica.historia;

delete from maquinaria.ordentrabajo;
delete from inntecc.empleadoareaproyecto;
delete from inntecc.empleadoarea;
delete from inntecc.documentoaprobacion;
delete from inntecc.etapaautorizaciondetalle;
delete from caja.cierrecaja;
DELETE from inntecc.usuario  where nombreusuario <> 'ADMIN';

delete from inntecc.empleado;

delete from inntecc.socionegociogarantia;
delete from inntecc.socionegociomarca;
delete from inntecc.personacontacto;
delete from inntecc.socionegocio;
delete from inntecc.persona;

update almacen.almacen set idubicaciondefecto = null;

delete from almacen.almacen;
delete from almacen.ubicacion;

delete from inntecc.centrodecosto;
delete from inntecc.proyecto;
delete from inntecc.periodo;
delete from inntecc.area;
delete from inntecc.empleadoarea;
delete from inntecc.marca;