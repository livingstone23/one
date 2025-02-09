using System.ComponentModel.DataAnnotations;



namespace One.Domain.entities.BaseClasses;



/// <summary>
/// Clase base para los modelos/entidades de negocio.
/// </summary>
public abstract class BaseDomainModel 
{

    #region Properties

    /// <summary>
    /// Obtiene o establece el identificador de la entidad.
    /// </summary>
    [Key]
    public Guid Oid { get; set; }

    /// <summary>
    /// Si el campo tiene un valor, indica que el registro ha sido eliminado lógicamente.
    /// </summary>
    public int? GCRecord { get; set; }

    /// <summary>
    /// Valor entero que permite controlar el bloqueo sobre el registro durante una sesión.
    /// </summary>
    public int? OptimisticLockField { get; set; }

    /// <summary>
    /// Obtiene o establece la fecha de creación del registro.
    /// </summary>
    public DateTime? CreatedAt { get; set; }

    /// <summary>
    /// Obtiene o establece el nombre de inicio de sesión del usuario que ha creado el registro.
    /// </summary>
    [StringLength(60)]
    public string? CreatedBy { get; set; }

    /// <summary>
    /// Obtiene o establece la fecha de última modificación del registro.
    /// </summary>
    public DateTime? LastChangeAt { get; set; }

    /// <summary>
    /// Obtiene o establece el nombre de inicio de sesión del usuario de la última modificación del registro.
    /// </summary>
    [StringLength(60)]
    public string? LastChangeBy { get; set; }

    /// <summary>
    /// Obtiene o establece la fecha de eliminación lógica del registro.
    /// </summary>
    public DateTime? DeletedAt { get; set; }

    /// <summary>
    /// Obtiene o establece el nombre de inicio de sesión del usuario de eliminación lógica del registro.
    /// </summary>
    [StringLength(60)]
    public string? DeletedBy { get; set; }

    /// <summary>
    /// Obtiene un valor que indica si la entidad ha sido eliminada.
    /// </summary>
    public bool IsDeleted { get => GCRecord.HasValue; }

    #endregion

    


}