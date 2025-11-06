# 🧮 Calculadora de Área y Perímetro – Cuadrado

Aplicación desarrollada en **Visual Basic con Windows Forms** que permite calcular el **área** y el **perímetro** de un cuadrado a partir del valor de su lado. Este proyecto fue realizado como parte de una actividad evaluativa para el Instituto Profesional de Chile – IPCHILE.

---

## 📦 Características del proyecto

- Interfaz gráfica amigable y ordenada.
- Entrada de datos mediante `TextBox`.
- Resultados mostrados automáticamente en campos de solo lectura.
- Validación de entrada numérica y positiva.
- Ejecución de cálculo mediante botón o tecla Enter.
- Mensajes de error claros para entradas inválidas.

---

## 🖥️ Tecnologías utilizadas

- **Lenguaje:** Visual Basic .NET  
- **IDE:** Visual Studio 2022  
- **Framework:** Windows Forms

---

## 🎯 Funcionalidad

1. El usuario ingresa el valor del lado del cuadrado.
2. Al presionar el botón **Calcular** o la tecla **Enter**, se ejecuta la lógica:
   - Se valida que el valor sea numérico.
   - Se verifica que sea mayor a cero.
   - Se calcula el **perímetro** (`4 × lado`) y el **área** (`lado × lado`).
3. Los resultados se muestran en los campos correspondientes.

---

## 📸 Capturas de pantalla

### Diseño
*(Agregar imagen del formulario en modo diseño)*

### Ejecución
*(Agregar imagen del formulario funcionando con datos ingresados)*

---

## 🧩 Estructura del formulario

- `Label`: Indicadores de texto (“Lado”, “Perímetro”, “Área”).
- `TextBox txtLado`: Entrada de datos.
- `TextBox txtPerimetro`: Salida del cálculo del perímetro.
- `TextBox txtArea`: Salida del cálculo del área.
- `Button btnCalcular`: Ejecuta la lógica del programa.

---

## 🧠 Lógica del programa

```vb
Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
    Dim lado As Double

    If Double.TryParse(txtLado.Text, lado) Then
        If lado <= 0 Then
            MessageBox.Show("El valor del lado debe ser mayor a cero.", "Dato inválido")
            Exit Sub
        End If

        Dim perimetro As Double = 4 * lado
        Dim area As Double = lado * lado

        txtPerimetro.Text = perimetro.ToString()
        txtArea.Text = area.ToString()
    Else
        MessageBox.Show("Por favor ingrese un valor numérico válido para el lado.", "Error de entrada")
    End If
End Sub
