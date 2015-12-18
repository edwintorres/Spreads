using System.Runtime.InteropServices;

namespace Yeppp
{

	/// <summary>Basic arithmetic operations</summary>
	public partial class Core
	{


		/// <summary>Computes the dot product of two vectors of single precision (32-bit) floating-point elements.</summary>
		/// <exception cref="System.NullReferenceException">If xArray or yArray is null.</exception>
		/// <exception cref="System.DataMisalignedException">If xArray or yArray is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, yOffset is negative, yOffset + length exceeds the length of yArray, or length is negative.</exception>
		public static unsafe float DotProduct_V32fV32f_S32f(float[] xArray, int xOffset, float[] yArray, int yOffset, int length)
		{
			if (xOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (xOffset + length > xArray.Length)
				throw new System.IndexOutOfRangeException();

			if (yOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (yOffset + length > yArray.Length)
				throw new System.IndexOutOfRangeException();

			if (length < 0)
				throw new System.ArgumentException();

			fixed (float* x = &xArray[xOffset])
			{
				fixed (float* y = &yArray[yOffset])
				{
					return DotProduct_V32fV32f_S32f(x, y, length);
				}
			}
		}


		/// <summary>Computes the dot product of two vectors of double precision (64-bit) floating-point elements.</summary>
		/// <exception cref="System.NullReferenceException">If xArray or yArray is null.</exception>
		/// <exception cref="System.DataMisalignedException">If xArray or yArray is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, yOffset is negative, yOffset + length exceeds the length of yArray, or length is negative.</exception>
		public static unsafe double DotProduct_V64fV64f_S64f(double[] xArray, int xOffset, double[] yArray, int yOffset, int length)
		{
			if (xOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (xOffset + length > xArray.Length)
				throw new System.IndexOutOfRangeException();

			if (yOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (yOffset + length > yArray.Length)
				throw new System.IndexOutOfRangeException();

			if (length < 0)
				throw new System.ArgumentException();

			fixed (double* x = &xArray[xOffset])
			{
				fixed (double* y = &yArray[yOffset])
				{
					return DotProduct_V64fV64f_S64f(x, y, length);
				}
			}
		}


		/// <summary>Computes the dot product of two vectors of single precision (32-bit) floating-point elements.</summary>
		/// <param name="x">Pointer to the first vector of elements.</param>
		/// <param name="y">Pointer to the second vector of elements.</param>
		/// <param name="length">Length of the vectors specified by x and y.</param>
		/// <exception cref="System.NullReferenceException">If x or y is null.</exception>
		/// <exception cref="System.DataMisalignedException">If x or y is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		public static unsafe float DotProduct_V32fV32f_S32f(float* x, float* y, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			float dotProduct;
			Status status = yepCore_DotProduct_V32fV32f_S32f(x, y, out dotProduct, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
			return dotProduct;
		}


		/// <summary>Computes the dot product of two vectors of double precision (64-bit) floating-point elements.</summary>
		/// <param name="x">Pointer to the first vector of elements.</param>
		/// <param name="y">Pointer to the second vector of elements.</param>
		/// <param name="length">Length of the vectors specified by x and y.</param>
		/// <exception cref="System.NullReferenceException">If x or y is null.</exception>
		/// <exception cref="System.DataMisalignedException">If x or y is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		public static unsafe double DotProduct_V64fV64f_S64f(double* x, double* y, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			double dotProduct;
			Status status = yepCore_DotProduct_V64fV64f_S64f(x, y, out dotProduct, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
			return dotProduct;
		}


		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepCore_DotProduct_V32fV32f_S32f")]
		private static unsafe extern Status yepCore_DotProduct_V32fV32f_S32f(float* x, float* y, out float dotProduct, System.UIntPtr length);

		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepCore_DotProduct_V64fV64f_S64f")]
		private static unsafe extern Status yepCore_DotProduct_V64fV64f_S64f(double* x, double* y, out double dotProduct, System.UIntPtr length);

	}

}
