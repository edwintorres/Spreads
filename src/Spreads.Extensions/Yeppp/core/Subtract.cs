using System.Runtime.InteropServices;

namespace Yeppp
{

	/// <summary>Basic arithmetic operations</summary>
	public partial class Core
	{


		/// <summary>Subtracts corresponding elements in two signed 8-bit integer arrays. Produces an array of signed 8-bit integer elements.</summary>
		/// <exception cref="System.NullReferenceException">If xArray, yArray or diffArray is null.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, yOffset is negative, yOffset + length exceeds the length of yArray, diffOffset is negative, diffOffset + length exceeds the length of diffArray, or length is negative.</exception>
		public static unsafe void Subtract_V8sV8s_V8s(sbyte[] xArray, int xOffset, sbyte[] yArray, int yOffset, sbyte[] diffArray, int diffOffset, int length)
		{
			if (xOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (xOffset + length > xArray.Length)
				throw new System.IndexOutOfRangeException();

			if (yOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (yOffset + length > yArray.Length)
				throw new System.IndexOutOfRangeException();

			if (diffOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (diffOffset + length > diffArray.Length)
				throw new System.IndexOutOfRangeException();

			if (length < 0)
				throw new System.ArgumentException();

			fixed (sbyte* x = &xArray[xOffset])
			{
				fixed (sbyte* y = &yArray[yOffset])
				{
					fixed (sbyte* diff = &diffArray[diffOffset])
					{
						Subtract_V8sV8s_V8s(x, y, diff, length);
					}
				}
			}
		}


		/// <summary>Subtracts corresponding elements in two signed 8-bit integer arrays. Produces an array of signed 16-bit integer elements.</summary>
		/// <exception cref="System.NullReferenceException">If xArray, yArray or diffArray is null.</exception>
		/// <exception cref="System.DataMisalignedException">If diffArray is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, yOffset is negative, yOffset + length exceeds the length of yArray, diffOffset is negative, diffOffset + length exceeds the length of diffArray, or length is negative.</exception>
		public static unsafe void Subtract_V8sV8s_V16s(sbyte[] xArray, int xOffset, sbyte[] yArray, int yOffset, short[] diffArray, int diffOffset, int length)
		{
			if (xOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (xOffset + length > xArray.Length)
				throw new System.IndexOutOfRangeException();

			if (yOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (yOffset + length > yArray.Length)
				throw new System.IndexOutOfRangeException();

			if (diffOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (diffOffset + length > diffArray.Length)
				throw new System.IndexOutOfRangeException();

			if (length < 0)
				throw new System.ArgumentException();

			fixed (sbyte* x = &xArray[xOffset])
			{
				fixed (sbyte* y = &yArray[yOffset])
				{
					fixed (short* diff = &diffArray[diffOffset])
					{
						Subtract_V8sV8s_V16s(x, y, diff, length);
					}
				}
			}
		}


		/// <summary>Subtracts corresponding elements in two unsigned 8-bit integer arrays. Produces an array of unsigned 16-bit integer elements.</summary>
		/// <exception cref="System.NullReferenceException">If xArray, yArray or diffArray is null.</exception>
		/// <exception cref="System.DataMisalignedException">If diffArray is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, yOffset is negative, yOffset + length exceeds the length of yArray, diffOffset is negative, diffOffset + length exceeds the length of diffArray, or length is negative.</exception>
		public static unsafe void Subtract_V8uV8u_V16u(byte[] xArray, int xOffset, byte[] yArray, int yOffset, ushort[] diffArray, int diffOffset, int length)
		{
			if (xOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (xOffset + length > xArray.Length)
				throw new System.IndexOutOfRangeException();

			if (yOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (yOffset + length > yArray.Length)
				throw new System.IndexOutOfRangeException();

			if (diffOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (diffOffset + length > diffArray.Length)
				throw new System.IndexOutOfRangeException();

			if (length < 0)
				throw new System.ArgumentException();

			fixed (byte* x = &xArray[xOffset])
			{
				fixed (byte* y = &yArray[yOffset])
				{
					fixed (ushort* diff = &diffArray[diffOffset])
					{
						Subtract_V8uV8u_V16u(x, y, diff, length);
					}
				}
			}
		}


		/// <summary>Subtracts corresponding elements in two signed 16-bit integer arrays. Produces an array of signed 16-bit integer elements.</summary>
		/// <exception cref="System.NullReferenceException">If xArray, yArray or diffArray is null.</exception>
		/// <exception cref="System.DataMisalignedException">If xArray, yArray or diffArray is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, yOffset is negative, yOffset + length exceeds the length of yArray, diffOffset is negative, diffOffset + length exceeds the length of diffArray, or length is negative.</exception>
		public static unsafe void Subtract_V16sV16s_V16s(short[] xArray, int xOffset, short[] yArray, int yOffset, short[] diffArray, int diffOffset, int length)
		{
			if (xOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (xOffset + length > xArray.Length)
				throw new System.IndexOutOfRangeException();

			if (yOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (yOffset + length > yArray.Length)
				throw new System.IndexOutOfRangeException();

			if (diffOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (diffOffset + length > diffArray.Length)
				throw new System.IndexOutOfRangeException();

			if (length < 0)
				throw new System.ArgumentException();

			fixed (short* x = &xArray[xOffset])
			{
				fixed (short* y = &yArray[yOffset])
				{
					fixed (short* diff = &diffArray[diffOffset])
					{
						Subtract_V16sV16s_V16s(x, y, diff, length);
					}
				}
			}
		}


		/// <summary>Subtracts corresponding elements in two signed 16-bit integer arrays. Produces an array of signed 32-bit integer elements.</summary>
		/// <exception cref="System.NullReferenceException">If xArray, yArray or diffArray is null.</exception>
		/// <exception cref="System.DataMisalignedException">If xArray, yArray or diffArray is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, yOffset is negative, yOffset + length exceeds the length of yArray, diffOffset is negative, diffOffset + length exceeds the length of diffArray, or length is negative.</exception>
		public static unsafe void Subtract_V16sV16s_V32s(short[] xArray, int xOffset, short[] yArray, int yOffset, int[] diffArray, int diffOffset, int length)
		{
			if (xOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (xOffset + length > xArray.Length)
				throw new System.IndexOutOfRangeException();

			if (yOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (yOffset + length > yArray.Length)
				throw new System.IndexOutOfRangeException();

			if (diffOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (diffOffset + length > diffArray.Length)
				throw new System.IndexOutOfRangeException();

			if (length < 0)
				throw new System.ArgumentException();

			fixed (short* x = &xArray[xOffset])
			{
				fixed (short* y = &yArray[yOffset])
				{
					fixed (int* diff = &diffArray[diffOffset])
					{
						Subtract_V16sV16s_V32s(x, y, diff, length);
					}
				}
			}
		}


		/// <summary>Subtracts corresponding elements in two unsigned 16-bit integer arrays. Produces an array of unsigned 32-bit integer elements.</summary>
		/// <exception cref="System.NullReferenceException">If xArray, yArray or diffArray is null.</exception>
		/// <exception cref="System.DataMisalignedException">If xArray, yArray or diffArray is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, yOffset is negative, yOffset + length exceeds the length of yArray, diffOffset is negative, diffOffset + length exceeds the length of diffArray, or length is negative.</exception>
		public static unsafe void Subtract_V16uV16u_V32u(ushort[] xArray, int xOffset, ushort[] yArray, int yOffset, uint[] diffArray, int diffOffset, int length)
		{
			if (xOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (xOffset + length > xArray.Length)
				throw new System.IndexOutOfRangeException();

			if (yOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (yOffset + length > yArray.Length)
				throw new System.IndexOutOfRangeException();

			if (diffOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (diffOffset + length > diffArray.Length)
				throw new System.IndexOutOfRangeException();

			if (length < 0)
				throw new System.ArgumentException();

			fixed (ushort* x = &xArray[xOffset])
			{
				fixed (ushort* y = &yArray[yOffset])
				{
					fixed (uint* diff = &diffArray[diffOffset])
					{
						Subtract_V16uV16u_V32u(x, y, diff, length);
					}
				}
			}
		}


		/// <summary>Subtracts corresponding elements in two signed 32-bit integer arrays. Produces an array of signed 32-bit integer elements.</summary>
		/// <exception cref="System.NullReferenceException">If xArray, yArray or diffArray is null.</exception>
		/// <exception cref="System.DataMisalignedException">If xArray, yArray or diffArray is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, yOffset is negative, yOffset + length exceeds the length of yArray, diffOffset is negative, diffOffset + length exceeds the length of diffArray, or length is negative.</exception>
		public static unsafe void Subtract_V32sV32s_V32s(int[] xArray, int xOffset, int[] yArray, int yOffset, int[] diffArray, int diffOffset, int length)
		{
			if (xOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (xOffset + length > xArray.Length)
				throw new System.IndexOutOfRangeException();

			if (yOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (yOffset + length > yArray.Length)
				throw new System.IndexOutOfRangeException();

			if (diffOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (diffOffset + length > diffArray.Length)
				throw new System.IndexOutOfRangeException();

			if (length < 0)
				throw new System.ArgumentException();

			fixed (int* x = &xArray[xOffset])
			{
				fixed (int* y = &yArray[yOffset])
				{
					fixed (int* diff = &diffArray[diffOffset])
					{
						Subtract_V32sV32s_V32s(x, y, diff, length);
					}
				}
			}
		}


		/// <summary>Subtracts corresponding elements in two signed 32-bit integer arrays. Produces an array of signed 64-bit integer elements.</summary>
		/// <exception cref="System.NullReferenceException">If xArray, yArray or diffArray is null.</exception>
		/// <exception cref="System.DataMisalignedException">If xArray, yArray or diffArray is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, yOffset is negative, yOffset + length exceeds the length of yArray, diffOffset is negative, diffOffset + length exceeds the length of diffArray, or length is negative.</exception>
		public static unsafe void Subtract_V32sV32s_V64s(int[] xArray, int xOffset, int[] yArray, int yOffset, long[] diffArray, int diffOffset, int length)
		{
			if (xOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (xOffset + length > xArray.Length)
				throw new System.IndexOutOfRangeException();

			if (yOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (yOffset + length > yArray.Length)
				throw new System.IndexOutOfRangeException();

			if (diffOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (diffOffset + length > diffArray.Length)
				throw new System.IndexOutOfRangeException();

			if (length < 0)
				throw new System.ArgumentException();

			fixed (int* x = &xArray[xOffset])
			{
				fixed (int* y = &yArray[yOffset])
				{
					fixed (long* diff = &diffArray[diffOffset])
					{
						Subtract_V32sV32s_V64s(x, y, diff, length);
					}
				}
			}
		}


		/// <summary>Subtracts corresponding elements in two unsigned 32-bit integer arrays. Produces an array of unsigned 64-bit integer elements.</summary>
		/// <exception cref="System.NullReferenceException">If xArray, yArray or diffArray is null.</exception>
		/// <exception cref="System.DataMisalignedException">If xArray, yArray or diffArray is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, yOffset is negative, yOffset + length exceeds the length of yArray, diffOffset is negative, diffOffset + length exceeds the length of diffArray, or length is negative.</exception>
		public static unsafe void Subtract_V32uV32u_V64u(uint[] xArray, int xOffset, uint[] yArray, int yOffset, ulong[] diffArray, int diffOffset, int length)
		{
			if (xOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (xOffset + length > xArray.Length)
				throw new System.IndexOutOfRangeException();

			if (yOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (yOffset + length > yArray.Length)
				throw new System.IndexOutOfRangeException();

			if (diffOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (diffOffset + length > diffArray.Length)
				throw new System.IndexOutOfRangeException();

			if (length < 0)
				throw new System.ArgumentException();

			fixed (uint* x = &xArray[xOffset])
			{
				fixed (uint* y = &yArray[yOffset])
				{
					fixed (ulong* diff = &diffArray[diffOffset])
					{
						Subtract_V32uV32u_V64u(x, y, diff, length);
					}
				}
			}
		}


		/// <summary>Subtracts corresponding elements in two signed 64-bit integer arrays. Produces an array of signed 64-bit integer elements.</summary>
		/// <exception cref="System.NullReferenceException">If xArray, yArray or diffArray is null.</exception>
		/// <exception cref="System.DataMisalignedException">If xArray, yArray or diffArray is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, yOffset is negative, yOffset + length exceeds the length of yArray, diffOffset is negative, diffOffset + length exceeds the length of diffArray, or length is negative.</exception>
		public static unsafe void Subtract_V64sV64s_V64s(long[] xArray, int xOffset, long[] yArray, int yOffset, long[] diffArray, int diffOffset, int length)
		{
			if (xOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (xOffset + length > xArray.Length)
				throw new System.IndexOutOfRangeException();

			if (yOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (yOffset + length > yArray.Length)
				throw new System.IndexOutOfRangeException();

			if (diffOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (diffOffset + length > diffArray.Length)
				throw new System.IndexOutOfRangeException();

			if (length < 0)
				throw new System.ArgumentException();

			fixed (long* x = &xArray[xOffset])
			{
				fixed (long* y = &yArray[yOffset])
				{
					fixed (long* diff = &diffArray[diffOffset])
					{
						Subtract_V64sV64s_V64s(x, y, diff, length);
					}
				}
			}
		}


		/// <summary>Subtracts corresponding elements in two single precision (32-bit) floating-point arrays. Produces an array of single precision (32-bit) floating-point elements.</summary>
		/// <exception cref="System.NullReferenceException">If xArray, yArray or diffArray is null.</exception>
		/// <exception cref="System.DataMisalignedException">If xArray, yArray or diffArray is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, yOffset is negative, yOffset + length exceeds the length of yArray, diffOffset is negative, diffOffset + length exceeds the length of diffArray, or length is negative.</exception>
		public static unsafe void Subtract_V32fV32f_V32f(float[] xArray, int xOffset, float[] yArray, int yOffset, float[] diffArray, int diffOffset, int length)
		{
			if (xOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (xOffset + length > xArray.Length)
				throw new System.IndexOutOfRangeException();

			if (yOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (yOffset + length > yArray.Length)
				throw new System.IndexOutOfRangeException();

			if (diffOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (diffOffset + length > diffArray.Length)
				throw new System.IndexOutOfRangeException();

			if (length < 0)
				throw new System.ArgumentException();

			fixed (float* x = &xArray[xOffset])
			{
				fixed (float* y = &yArray[yOffset])
				{
					fixed (float* diff = &diffArray[diffOffset])
					{
						Subtract_V32fV32f_V32f(x, y, diff, length);
					}
				}
			}
		}


		/// <summary>Subtracts corresponding elements in two double precision (64-bit) floating-point arrays. Produces an array of double precision (64-bit) floating-point elements.</summary>
		/// <exception cref="System.NullReferenceException">If xArray, yArray or diffArray is null.</exception>
		/// <exception cref="System.DataMisalignedException">If xArray, yArray or diffArray is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, yOffset is negative, yOffset + length exceeds the length of yArray, diffOffset is negative, diffOffset + length exceeds the length of diffArray, or length is negative.</exception>
		public static unsafe void Subtract_V64fV64f_V64f(double[] xArray, int xOffset, double[] yArray, int yOffset, double[] diffArray, int diffOffset, int length)
		{
			if (xOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (xOffset + length > xArray.Length)
				throw new System.IndexOutOfRangeException();

			if (yOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (yOffset + length > yArray.Length)
				throw new System.IndexOutOfRangeException();

			if (diffOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (diffOffset + length > diffArray.Length)
				throw new System.IndexOutOfRangeException();

			if (length < 0)
				throw new System.ArgumentException();

			fixed (double* x = &xArray[xOffset])
			{
				fixed (double* y = &yArray[yOffset])
				{
					fixed (double* diff = &diffArray[diffOffset])
					{
						Subtract_V64fV64f_V64f(x, y, diff, length);
					}
				}
			}
		}


		/// <summary>Subtracts corresponding elements in two signed 8-bit integer arrays. Produces an array of signed 8-bit integer elements.</summary>
		/// <exception cref="System.NullReferenceException">If xArray or diffArray is null.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, diffOffset is negative, diffOffset + length exceeds the length of diffArray, or length is negative.</exception>
		public static unsafe void Subtract_V8sS8s_V8s(sbyte[] xArray, int xOffset, sbyte y, sbyte[] diffArray, int diffOffset, int length)
		{
			if (xOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (xOffset + length > xArray.Length)
				throw new System.IndexOutOfRangeException();

			if (diffOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (diffOffset + length > diffArray.Length)
				throw new System.IndexOutOfRangeException();

			if (length < 0)
				throw new System.ArgumentException();

			fixed (sbyte* x = &xArray[xOffset])
			{
				fixed (sbyte* diff = &diffArray[diffOffset])
				{
					Subtract_V8sS8s_V8s(x, y, diff, length);
				}
			}
		}


		/// <summary>Subtracts corresponding elements in two signed 8-bit integer arrays. Produces an array of signed 16-bit integer elements.</summary>
		/// <exception cref="System.NullReferenceException">If xArray or diffArray is null.</exception>
		/// <exception cref="System.DataMisalignedException">If diffArray is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, diffOffset is negative, diffOffset + length exceeds the length of diffArray, or length is negative.</exception>
		public static unsafe void Subtract_V8sS8s_V16s(sbyte[] xArray, int xOffset, sbyte y, short[] diffArray, int diffOffset, int length)
		{
			if (xOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (xOffset + length > xArray.Length)
				throw new System.IndexOutOfRangeException();

			if (diffOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (diffOffset + length > diffArray.Length)
				throw new System.IndexOutOfRangeException();

			if (length < 0)
				throw new System.ArgumentException();

			fixed (sbyte* x = &xArray[xOffset])
			{
				fixed (short* diff = &diffArray[diffOffset])
				{
					Subtract_V8sS8s_V16s(x, y, diff, length);
				}
			}
		}


		/// <summary>Subtracts corresponding elements in two unsigned 8-bit integer arrays. Produces an array of unsigned 16-bit integer elements.</summary>
		/// <exception cref="System.NullReferenceException">If xArray or diffArray is null.</exception>
		/// <exception cref="System.DataMisalignedException">If diffArray is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, diffOffset is negative, diffOffset + length exceeds the length of diffArray, or length is negative.</exception>
		public static unsafe void Subtract_V8uS8u_V16u(byte[] xArray, int xOffset, byte y, ushort[] diffArray, int diffOffset, int length)
		{
			if (xOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (xOffset + length > xArray.Length)
				throw new System.IndexOutOfRangeException();

			if (diffOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (diffOffset + length > diffArray.Length)
				throw new System.IndexOutOfRangeException();

			if (length < 0)
				throw new System.ArgumentException();

			fixed (byte* x = &xArray[xOffset])
			{
				fixed (ushort* diff = &diffArray[diffOffset])
				{
					Subtract_V8uS8u_V16u(x, y, diff, length);
				}
			}
		}


		/// <summary>Subtracts corresponding elements in two signed 16-bit integer arrays. Produces an array of signed 16-bit integer elements.</summary>
		/// <exception cref="System.NullReferenceException">If xArray or diffArray is null.</exception>
		/// <exception cref="System.DataMisalignedException">If xArray or diffArray is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, diffOffset is negative, diffOffset + length exceeds the length of diffArray, or length is negative.</exception>
		public static unsafe void Subtract_V16sS16s_V16s(short[] xArray, int xOffset, short y, short[] diffArray, int diffOffset, int length)
		{
			if (xOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (xOffset + length > xArray.Length)
				throw new System.IndexOutOfRangeException();

			if (diffOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (diffOffset + length > diffArray.Length)
				throw new System.IndexOutOfRangeException();

			if (length < 0)
				throw new System.ArgumentException();

			fixed (short* x = &xArray[xOffset])
			{
				fixed (short* diff = &diffArray[diffOffset])
				{
					Subtract_V16sS16s_V16s(x, y, diff, length);
				}
			}
		}


		/// <summary>Subtracts corresponding elements in two signed 16-bit integer arrays. Produces an array of signed 32-bit integer elements.</summary>
		/// <exception cref="System.NullReferenceException">If xArray or diffArray is null.</exception>
		/// <exception cref="System.DataMisalignedException">If xArray or diffArray is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, diffOffset is negative, diffOffset + length exceeds the length of diffArray, or length is negative.</exception>
		public static unsafe void Subtract_V16sS16s_V32s(short[] xArray, int xOffset, short y, int[] diffArray, int diffOffset, int length)
		{
			if (xOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (xOffset + length > xArray.Length)
				throw new System.IndexOutOfRangeException();

			if (diffOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (diffOffset + length > diffArray.Length)
				throw new System.IndexOutOfRangeException();

			if (length < 0)
				throw new System.ArgumentException();

			fixed (short* x = &xArray[xOffset])
			{
				fixed (int* diff = &diffArray[diffOffset])
				{
					Subtract_V16sS16s_V32s(x, y, diff, length);
				}
			}
		}


		/// <summary>Subtracts corresponding elements in two unsigned 16-bit integer arrays. Produces an array of unsigned 32-bit integer elements.</summary>
		/// <exception cref="System.NullReferenceException">If xArray or diffArray is null.</exception>
		/// <exception cref="System.DataMisalignedException">If xArray or diffArray is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, diffOffset is negative, diffOffset + length exceeds the length of diffArray, or length is negative.</exception>
		public static unsafe void Subtract_V16uS16u_V32u(ushort[] xArray, int xOffset, ushort y, uint[] diffArray, int diffOffset, int length)
		{
			if (xOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (xOffset + length > xArray.Length)
				throw new System.IndexOutOfRangeException();

			if (diffOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (diffOffset + length > diffArray.Length)
				throw new System.IndexOutOfRangeException();

			if (length < 0)
				throw new System.ArgumentException();

			fixed (ushort* x = &xArray[xOffset])
			{
				fixed (uint* diff = &diffArray[diffOffset])
				{
					Subtract_V16uS16u_V32u(x, y, diff, length);
				}
			}
		}


		/// <summary>Subtracts corresponding elements in two signed 32-bit integer arrays. Produces an array of signed 32-bit integer elements.</summary>
		/// <exception cref="System.NullReferenceException">If xArray or diffArray is null.</exception>
		/// <exception cref="System.DataMisalignedException">If xArray or diffArray is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, diffOffset is negative, diffOffset + length exceeds the length of diffArray, or length is negative.</exception>
		public static unsafe void Subtract_V32sS32s_V32s(int[] xArray, int xOffset, int y, int[] diffArray, int diffOffset, int length)
		{
			if (xOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (xOffset + length > xArray.Length)
				throw new System.IndexOutOfRangeException();

			if (diffOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (diffOffset + length > diffArray.Length)
				throw new System.IndexOutOfRangeException();

			if (length < 0)
				throw new System.ArgumentException();

			fixed (int* x = &xArray[xOffset])
			{
				fixed (int* diff = &diffArray[diffOffset])
				{
					Subtract_V32sS32s_V32s(x, y, diff, length);
				}
			}
		}


		/// <summary>Subtracts corresponding elements in two signed 32-bit integer arrays. Produces an array of signed 64-bit integer elements.</summary>
		/// <exception cref="System.NullReferenceException">If xArray or diffArray is null.</exception>
		/// <exception cref="System.DataMisalignedException">If xArray or diffArray is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, diffOffset is negative, diffOffset + length exceeds the length of diffArray, or length is negative.</exception>
		public static unsafe void Subtract_V32sS32s_V64s(int[] xArray, int xOffset, int y, long[] diffArray, int diffOffset, int length)
		{
			if (xOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (xOffset + length > xArray.Length)
				throw new System.IndexOutOfRangeException();

			if (diffOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (diffOffset + length > diffArray.Length)
				throw new System.IndexOutOfRangeException();

			if (length < 0)
				throw new System.ArgumentException();

			fixed (int* x = &xArray[xOffset])
			{
				fixed (long* diff = &diffArray[diffOffset])
				{
					Subtract_V32sS32s_V64s(x, y, diff, length);
				}
			}
		}


		/// <summary>Subtracts corresponding elements in two unsigned 32-bit integer arrays. Produces an array of unsigned 64-bit integer elements.</summary>
		/// <exception cref="System.NullReferenceException">If xArray or diffArray is null.</exception>
		/// <exception cref="System.DataMisalignedException">If xArray or diffArray is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, diffOffset is negative, diffOffset + length exceeds the length of diffArray, or length is negative.</exception>
		public static unsafe void Subtract_V32uS32u_V64u(uint[] xArray, int xOffset, uint y, ulong[] diffArray, int diffOffset, int length)
		{
			if (xOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (xOffset + length > xArray.Length)
				throw new System.IndexOutOfRangeException();

			if (diffOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (diffOffset + length > diffArray.Length)
				throw new System.IndexOutOfRangeException();

			if (length < 0)
				throw new System.ArgumentException();

			fixed (uint* x = &xArray[xOffset])
			{
				fixed (ulong* diff = &diffArray[diffOffset])
				{
					Subtract_V32uS32u_V64u(x, y, diff, length);
				}
			}
		}


		/// <summary>Subtracts corresponding elements in two signed 64-bit integer arrays. Produces an array of signed 64-bit integer elements.</summary>
		/// <exception cref="System.NullReferenceException">If xArray or diffArray is null.</exception>
		/// <exception cref="System.DataMisalignedException">If xArray or diffArray is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, diffOffset is negative, diffOffset + length exceeds the length of diffArray, or length is negative.</exception>
		public static unsafe void Subtract_V64sS64s_V64s(long[] xArray, int xOffset, long y, long[] diffArray, int diffOffset, int length)
		{
			if (xOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (xOffset + length > xArray.Length)
				throw new System.IndexOutOfRangeException();

			if (diffOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (diffOffset + length > diffArray.Length)
				throw new System.IndexOutOfRangeException();

			if (length < 0)
				throw new System.ArgumentException();

			fixed (long* x = &xArray[xOffset])
			{
				fixed (long* diff = &diffArray[diffOffset])
				{
					Subtract_V64sS64s_V64s(x, y, diff, length);
				}
			}
		}


		/// <summary>Subtracts corresponding elements in two single precision (32-bit) floating-point arrays. Produces an array of single precision (32-bit) floating-point elements.</summary>
		/// <exception cref="System.NullReferenceException">If xArray or diffArray is null.</exception>
		/// <exception cref="System.DataMisalignedException">If xArray or diffArray is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, diffOffset is negative, diffOffset + length exceeds the length of diffArray, or length is negative.</exception>
		public static unsafe void Subtract_V32fS32f_V32f(float[] xArray, int xOffset, float y, float[] diffArray, int diffOffset, int length)
		{
			if (xOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (xOffset + length > xArray.Length)
				throw new System.IndexOutOfRangeException();

			if (diffOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (diffOffset + length > diffArray.Length)
				throw new System.IndexOutOfRangeException();

			if (length < 0)
				throw new System.ArgumentException();

			fixed (float* x = &xArray[xOffset])
			{
				fixed (float* diff = &diffArray[diffOffset])
				{
					Subtract_V32fS32f_V32f(x, y, diff, length);
				}
			}
		}


		/// <summary>Subtracts corresponding elements in two double precision (64-bit) floating-point arrays. Produces an array of double precision (64-bit) floating-point elements.</summary>
		/// <exception cref="System.NullReferenceException">If xArray or diffArray is null.</exception>
		/// <exception cref="System.DataMisalignedException">If xArray or diffArray is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, diffOffset is negative, diffOffset + length exceeds the length of diffArray, or length is negative.</exception>
		public static unsafe void Subtract_V64fS64f_V64f(double[] xArray, int xOffset, double y, double[] diffArray, int diffOffset, int length)
		{
			if (xOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (xOffset + length > xArray.Length)
				throw new System.IndexOutOfRangeException();

			if (diffOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (diffOffset + length > diffArray.Length)
				throw new System.IndexOutOfRangeException();

			if (length < 0)
				throw new System.ArgumentException();

			fixed (double* x = &xArray[xOffset])
			{
				fixed (double* diff = &diffArray[diffOffset])
				{
					Subtract_V64fS64f_V64f(x, y, diff, length);
				}
			}
		}


		/// <summary>Subtracts signed 8-bit integer array elements from a constant. Produces an array of signed 8-bit integer elements.</summary>
		/// <exception cref="System.NullReferenceException">If yArray or diffArray is null.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If yOffset is negative, yOffset + length exceeds the length of yArray, diffOffset is negative, diffOffset + length exceeds the length of diffArray, or length is negative.</exception>
		public static unsafe void Subtract_S8sV8s_V8s(sbyte x, sbyte[] yArray, int yOffset, sbyte[] diffArray, int diffOffset, int length)
		{
			if (yOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (yOffset + length > yArray.Length)
				throw new System.IndexOutOfRangeException();

			if (diffOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (diffOffset + length > diffArray.Length)
				throw new System.IndexOutOfRangeException();

			if (length < 0)
				throw new System.ArgumentException();

			fixed (sbyte* y = &yArray[yOffset])
			{
				fixed (sbyte* diff = &diffArray[diffOffset])
				{
					Subtract_S8sV8s_V8s(x, y, diff, length);
				}
			}
		}


		/// <summary>Subtracts signed 8-bit integer array elements from a constant. Produces an array of signed 16-bit integer elements.</summary>
		/// <exception cref="System.NullReferenceException">If yArray or diffArray is null.</exception>
		/// <exception cref="System.DataMisalignedException">If diffArray is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If yOffset is negative, yOffset + length exceeds the length of yArray, diffOffset is negative, diffOffset + length exceeds the length of diffArray, or length is negative.</exception>
		public static unsafe void Subtract_S8sV8s_V16s(sbyte x, sbyte[] yArray, int yOffset, short[] diffArray, int diffOffset, int length)
		{
			if (yOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (yOffset + length > yArray.Length)
				throw new System.IndexOutOfRangeException();

			if (diffOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (diffOffset + length > diffArray.Length)
				throw new System.IndexOutOfRangeException();

			if (length < 0)
				throw new System.ArgumentException();

			fixed (sbyte* y = &yArray[yOffset])
			{
				fixed (short* diff = &diffArray[diffOffset])
				{
					Subtract_S8sV8s_V16s(x, y, diff, length);
				}
			}
		}


		/// <summary>Subtracts unsigned 8-bit integer array elements from a constant. Produces an array of unsigned 16-bit integer elements.</summary>
		/// <exception cref="System.NullReferenceException">If yArray or diffArray is null.</exception>
		/// <exception cref="System.DataMisalignedException">If diffArray is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If yOffset is negative, yOffset + length exceeds the length of yArray, diffOffset is negative, diffOffset + length exceeds the length of diffArray, or length is negative.</exception>
		public static unsafe void Subtract_S8uV8u_V16u(byte x, byte[] yArray, int yOffset, ushort[] diffArray, int diffOffset, int length)
		{
			if (yOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (yOffset + length > yArray.Length)
				throw new System.IndexOutOfRangeException();

			if (diffOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (diffOffset + length > diffArray.Length)
				throw new System.IndexOutOfRangeException();

			if (length < 0)
				throw new System.ArgumentException();

			fixed (byte* y = &yArray[yOffset])
			{
				fixed (ushort* diff = &diffArray[diffOffset])
				{
					Subtract_S8uV8u_V16u(x, y, diff, length);
				}
			}
		}


		/// <summary>Subtracts signed 16-bit integer array elements from a constant. Produces an array of signed 16-bit integer elements.</summary>
		/// <exception cref="System.NullReferenceException">If yArray or diffArray is null.</exception>
		/// <exception cref="System.DataMisalignedException">If yArray or diffArray is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If yOffset is negative, yOffset + length exceeds the length of yArray, diffOffset is negative, diffOffset + length exceeds the length of diffArray, or length is negative.</exception>
		public static unsafe void Subtract_S16sV16s_V16s(short x, short[] yArray, int yOffset, short[] diffArray, int diffOffset, int length)
		{
			if (yOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (yOffset + length > yArray.Length)
				throw new System.IndexOutOfRangeException();

			if (diffOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (diffOffset + length > diffArray.Length)
				throw new System.IndexOutOfRangeException();

			if (length < 0)
				throw new System.ArgumentException();

			fixed (short* y = &yArray[yOffset])
			{
				fixed (short* diff = &diffArray[diffOffset])
				{
					Subtract_S16sV16s_V16s(x, y, diff, length);
				}
			}
		}


		/// <summary>Subtracts signed 16-bit integer array elements from a constant. Produces an array of signed 32-bit integer elements.</summary>
		/// <exception cref="System.NullReferenceException">If yArray or diffArray is null.</exception>
		/// <exception cref="System.DataMisalignedException">If yArray or diffArray is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If yOffset is negative, yOffset + length exceeds the length of yArray, diffOffset is negative, diffOffset + length exceeds the length of diffArray, or length is negative.</exception>
		public static unsafe void Subtract_S16sV16s_V32s(short x, short[] yArray, int yOffset, int[] diffArray, int diffOffset, int length)
		{
			if (yOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (yOffset + length > yArray.Length)
				throw new System.IndexOutOfRangeException();

			if (diffOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (diffOffset + length > diffArray.Length)
				throw new System.IndexOutOfRangeException();

			if (length < 0)
				throw new System.ArgumentException();

			fixed (short* y = &yArray[yOffset])
			{
				fixed (int* diff = &diffArray[diffOffset])
				{
					Subtract_S16sV16s_V32s(x, y, diff, length);
				}
			}
		}


		/// <summary>Subtracts unsigned 16-bit integer array elements from a constant. Produces an array of unsigned 32-bit integer elements.</summary>
		/// <exception cref="System.NullReferenceException">If yArray or diffArray is null.</exception>
		/// <exception cref="System.DataMisalignedException">If yArray or diffArray is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If yOffset is negative, yOffset + length exceeds the length of yArray, diffOffset is negative, diffOffset + length exceeds the length of diffArray, or length is negative.</exception>
		public static unsafe void Subtract_S16uV16u_V32u(ushort x, ushort[] yArray, int yOffset, uint[] diffArray, int diffOffset, int length)
		{
			if (yOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (yOffset + length > yArray.Length)
				throw new System.IndexOutOfRangeException();

			if (diffOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (diffOffset + length > diffArray.Length)
				throw new System.IndexOutOfRangeException();

			if (length < 0)
				throw new System.ArgumentException();

			fixed (ushort* y = &yArray[yOffset])
			{
				fixed (uint* diff = &diffArray[diffOffset])
				{
					Subtract_S16uV16u_V32u(x, y, diff, length);
				}
			}
		}


		/// <summary>Subtracts signed 32-bit integer array elements from a constant. Produces an array of signed 32-bit integer elements.</summary>
		/// <exception cref="System.NullReferenceException">If yArray or diffArray is null.</exception>
		/// <exception cref="System.DataMisalignedException">If yArray or diffArray is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If yOffset is negative, yOffset + length exceeds the length of yArray, diffOffset is negative, diffOffset + length exceeds the length of diffArray, or length is negative.</exception>
		public static unsafe void Subtract_S32sV32s_V32s(int x, int[] yArray, int yOffset, int[] diffArray, int diffOffset, int length)
		{
			if (yOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (yOffset + length > yArray.Length)
				throw new System.IndexOutOfRangeException();

			if (diffOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (diffOffset + length > diffArray.Length)
				throw new System.IndexOutOfRangeException();

			if (length < 0)
				throw new System.ArgumentException();

			fixed (int* y = &yArray[yOffset])
			{
				fixed (int* diff = &diffArray[diffOffset])
				{
					Subtract_S32sV32s_V32s(x, y, diff, length);
				}
			}
		}


		/// <summary>Subtracts signed 32-bit integer array elements from a constant. Produces an array of signed 64-bit integer elements.</summary>
		/// <exception cref="System.NullReferenceException">If yArray or diffArray is null.</exception>
		/// <exception cref="System.DataMisalignedException">If yArray or diffArray is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If yOffset is negative, yOffset + length exceeds the length of yArray, diffOffset is negative, diffOffset + length exceeds the length of diffArray, or length is negative.</exception>
		public static unsafe void Subtract_S32sV32s_V64s(int x, int[] yArray, int yOffset, long[] diffArray, int diffOffset, int length)
		{
			if (yOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (yOffset + length > yArray.Length)
				throw new System.IndexOutOfRangeException();

			if (diffOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (diffOffset + length > diffArray.Length)
				throw new System.IndexOutOfRangeException();

			if (length < 0)
				throw new System.ArgumentException();

			fixed (int* y = &yArray[yOffset])
			{
				fixed (long* diff = &diffArray[diffOffset])
				{
					Subtract_S32sV32s_V64s(x, y, diff, length);
				}
			}
		}


		/// <summary>Subtracts unsigned 32-bit integer array elements from a constant. Produces an array of unsigned 64-bit integer elements.</summary>
		/// <exception cref="System.NullReferenceException">If yArray or diffArray is null.</exception>
		/// <exception cref="System.DataMisalignedException">If yArray or diffArray is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If yOffset is negative, yOffset + length exceeds the length of yArray, diffOffset is negative, diffOffset + length exceeds the length of diffArray, or length is negative.</exception>
		public static unsafe void Subtract_S32uV32u_V64u(uint x, uint[] yArray, int yOffset, ulong[] diffArray, int diffOffset, int length)
		{
			if (yOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (yOffset + length > yArray.Length)
				throw new System.IndexOutOfRangeException();

			if (diffOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (diffOffset + length > diffArray.Length)
				throw new System.IndexOutOfRangeException();

			if (length < 0)
				throw new System.ArgumentException();

			fixed (uint* y = &yArray[yOffset])
			{
				fixed (ulong* diff = &diffArray[diffOffset])
				{
					Subtract_S32uV32u_V64u(x, y, diff, length);
				}
			}
		}


		/// <summary>Subtracts signed 64-bit integer array elements from a constant. Produces an array of signed 64-bit integer elements.</summary>
		/// <exception cref="System.NullReferenceException">If yArray or diffArray is null.</exception>
		/// <exception cref="System.DataMisalignedException">If yArray or diffArray is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If yOffset is negative, yOffset + length exceeds the length of yArray, diffOffset is negative, diffOffset + length exceeds the length of diffArray, or length is negative.</exception>
		public static unsafe void Subtract_S64sV64s_V64s(long x, long[] yArray, int yOffset, long[] diffArray, int diffOffset, int length)
		{
			if (yOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (yOffset + length > yArray.Length)
				throw new System.IndexOutOfRangeException();

			if (diffOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (diffOffset + length > diffArray.Length)
				throw new System.IndexOutOfRangeException();

			if (length < 0)
				throw new System.ArgumentException();

			fixed (long* y = &yArray[yOffset])
			{
				fixed (long* diff = &diffArray[diffOffset])
				{
					Subtract_S64sV64s_V64s(x, y, diff, length);
				}
			}
		}


		/// <summary>Subtracts single precision (32-bit) floating-point array elements from a constant. Produces an array of single precision (32-bit) floating-point elements.</summary>
		/// <exception cref="System.NullReferenceException">If yArray or diffArray is null.</exception>
		/// <exception cref="System.DataMisalignedException">If yArray or diffArray is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If yOffset is negative, yOffset + length exceeds the length of yArray, diffOffset is negative, diffOffset + length exceeds the length of diffArray, or length is negative.</exception>
		public static unsafe void Subtract_S32fV32f_V32f(float x, float[] yArray, int yOffset, float[] diffArray, int diffOffset, int length)
		{
			if (yOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (yOffset + length > yArray.Length)
				throw new System.IndexOutOfRangeException();

			if (diffOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (diffOffset + length > diffArray.Length)
				throw new System.IndexOutOfRangeException();

			if (length < 0)
				throw new System.ArgumentException();

			fixed (float* y = &yArray[yOffset])
			{
				fixed (float* diff = &diffArray[diffOffset])
				{
					Subtract_S32fV32f_V32f(x, y, diff, length);
				}
			}
		}


		/// <summary>Subtracts double precision (64-bit) floating-point array elements from a constant. Produces an array of double precision (64-bit) floating-point elements.</summary>
		/// <exception cref="System.NullReferenceException">If yArray or diffArray is null.</exception>
		/// <exception cref="System.DataMisalignedException">If yArray or diffArray is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If yOffset is negative, yOffset + length exceeds the length of yArray, diffOffset is negative, diffOffset + length exceeds the length of diffArray, or length is negative.</exception>
		public static unsafe void Subtract_S64fV64f_V64f(double x, double[] yArray, int yOffset, double[] diffArray, int diffOffset, int length)
		{
			if (yOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (yOffset + length > yArray.Length)
				throw new System.IndexOutOfRangeException();

			if (diffOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (diffOffset + length > diffArray.Length)
				throw new System.IndexOutOfRangeException();

			if (length < 0)
				throw new System.ArgumentException();

			fixed (double* y = &yArray[yOffset])
			{
				fixed (double* diff = &diffArray[diffOffset])
				{
					Subtract_S64fV64f_V64f(x, y, diff, length);
				}
			}
		}


		/// <summary>Subtracts corresponding elements in two signed 8-bit integer arrays and writes the result to the first array.</summary>
		/// <exception cref="System.NullReferenceException">If xArray or yArray is null.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, yOffset is negative, yOffset + length exceeds the length of yArray, or length is negative.</exception>
		public static unsafe void Subtract_IV8sV8s_IV8s(sbyte[] xArray, int xOffset, sbyte[] yArray, int yOffset, int length)
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

			fixed (sbyte* x = &xArray[xOffset])
			{
				fixed (sbyte* y = &yArray[yOffset])
				{
					Subtract_IV8sV8s_IV8s(x, y, length);
				}
			}
		}


		/// <summary>Subtracts corresponding elements in two signed 16-bit integer arrays and writes the result to the first array.</summary>
		/// <exception cref="System.NullReferenceException">If xArray or yArray is null.</exception>
		/// <exception cref="System.DataMisalignedException">If xArray or yArray is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, yOffset is negative, yOffset + length exceeds the length of yArray, or length is negative.</exception>
		public static unsafe void Subtract_IV16sV16s_IV16s(short[] xArray, int xOffset, short[] yArray, int yOffset, int length)
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

			fixed (short* x = &xArray[xOffset])
			{
				fixed (short* y = &yArray[yOffset])
				{
					Subtract_IV16sV16s_IV16s(x, y, length);
				}
			}
		}


		/// <summary>Subtracts corresponding elements in two signed 32-bit integer arrays and writes the result to the first array.</summary>
		/// <exception cref="System.NullReferenceException">If xArray or yArray is null.</exception>
		/// <exception cref="System.DataMisalignedException">If xArray or yArray is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, yOffset is negative, yOffset + length exceeds the length of yArray, or length is negative.</exception>
		public static unsafe void Subtract_IV32sV32s_IV32s(int[] xArray, int xOffset, int[] yArray, int yOffset, int length)
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

			fixed (int* x = &xArray[xOffset])
			{
				fixed (int* y = &yArray[yOffset])
				{
					Subtract_IV32sV32s_IV32s(x, y, length);
				}
			}
		}


		/// <summary>Subtracts corresponding elements in two signed 64-bit integer arrays and writes the result to the first array.</summary>
		/// <exception cref="System.NullReferenceException">If xArray or yArray is null.</exception>
		/// <exception cref="System.DataMisalignedException">If xArray or yArray is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, yOffset is negative, yOffset + length exceeds the length of yArray, or length is negative.</exception>
		public static unsafe void Subtract_IV64sV64s_IV64s(long[] xArray, int xOffset, long[] yArray, int yOffset, int length)
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

			fixed (long* x = &xArray[xOffset])
			{
				fixed (long* y = &yArray[yOffset])
				{
					Subtract_IV64sV64s_IV64s(x, y, length);
				}
			}
		}


		/// <summary>Subtracts corresponding elements in two single precision (32-bit) floating-point arrays and writes the result to the first array.</summary>
		/// <exception cref="System.NullReferenceException">If xArray or yArray is null.</exception>
		/// <exception cref="System.DataMisalignedException">If xArray or yArray is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, yOffset is negative, yOffset + length exceeds the length of yArray, or length is negative.</exception>
		public static unsafe void Subtract_IV32fV32f_IV32f(float[] xArray, int xOffset, float[] yArray, int yOffset, int length)
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
					Subtract_IV32fV32f_IV32f(x, y, length);
				}
			}
		}


		/// <summary>Subtracts corresponding elements in two double precision (64-bit) floating-point arrays and writes the result to the first array.</summary>
		/// <exception cref="System.NullReferenceException">If xArray or yArray is null.</exception>
		/// <exception cref="System.DataMisalignedException">If xArray or yArray is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, yOffset is negative, yOffset + length exceeds the length of yArray, or length is negative.</exception>
		public static unsafe void Subtract_IV64fV64f_IV64f(double[] xArray, int xOffset, double[] yArray, int yOffset, int length)
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
					Subtract_IV64fV64f_IV64f(x, y, length);
				}
			}
		}


		/// <summary>Subtracts corresponding elements in two signed 8-bit integer arrays and writes the result to the second array.</summary>
		/// <exception cref="System.NullReferenceException">If xArray or yArray is null.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, yOffset is negative, yOffset + length exceeds the length of yArray, or length is negative.</exception>
		public static unsafe void Subtract_V8sIV8s_IV8s(sbyte[] xArray, int xOffset, sbyte[] yArray, int yOffset, int length)
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

			fixed (sbyte* x = &xArray[xOffset])
			{
				fixed (sbyte* y = &yArray[yOffset])
				{
					Subtract_V8sIV8s_IV8s(x, y, length);
				}
			}
		}


		/// <summary>Subtracts corresponding elements in two signed 16-bit integer arrays and writes the result to the second array.</summary>
		/// <exception cref="System.NullReferenceException">If xArray or yArray is null.</exception>
		/// <exception cref="System.DataMisalignedException">If xArray or yArray is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, yOffset is negative, yOffset + length exceeds the length of yArray, or length is negative.</exception>
		public static unsafe void Subtract_V16sIV16s_IV16s(short[] xArray, int xOffset, short[] yArray, int yOffset, int length)
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

			fixed (short* x = &xArray[xOffset])
			{
				fixed (short* y = &yArray[yOffset])
				{
					Subtract_V16sIV16s_IV16s(x, y, length);
				}
			}
		}


		/// <summary>Subtracts corresponding elements in two signed 32-bit integer arrays and writes the result to the second array.</summary>
		/// <exception cref="System.NullReferenceException">If xArray or yArray is null.</exception>
		/// <exception cref="System.DataMisalignedException">If xArray or yArray is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, yOffset is negative, yOffset + length exceeds the length of yArray, or length is negative.</exception>
		public static unsafe void Subtract_V32sIV32s_IV32s(int[] xArray, int xOffset, int[] yArray, int yOffset, int length)
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

			fixed (int* x = &xArray[xOffset])
			{
				fixed (int* y = &yArray[yOffset])
				{
					Subtract_V32sIV32s_IV32s(x, y, length);
				}
			}
		}


		/// <summary>Subtracts corresponding elements in two signed 64-bit integer arrays and writes the result to the second array.</summary>
		/// <exception cref="System.NullReferenceException">If xArray or yArray is null.</exception>
		/// <exception cref="System.DataMisalignedException">If xArray or yArray is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, yOffset is negative, yOffset + length exceeds the length of yArray, or length is negative.</exception>
		public static unsafe void Subtract_V64sIV64s_IV64s(long[] xArray, int xOffset, long[] yArray, int yOffset, int length)
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

			fixed (long* x = &xArray[xOffset])
			{
				fixed (long* y = &yArray[yOffset])
				{
					Subtract_V64sIV64s_IV64s(x, y, length);
				}
			}
		}


		/// <summary>Subtracts corresponding elements in two single precision (32-bit) floating-point arrays and writes the result to the second array.</summary>
		/// <exception cref="System.NullReferenceException">If xArray or yArray is null.</exception>
		/// <exception cref="System.DataMisalignedException">If xArray or yArray is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, yOffset is negative, yOffset + length exceeds the length of yArray, or length is negative.</exception>
		public static unsafe void Subtract_V32fIV32f_IV32f(float[] xArray, int xOffset, float[] yArray, int yOffset, int length)
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
					Subtract_V32fIV32f_IV32f(x, y, length);
				}
			}
		}


		/// <summary>Subtracts corresponding elements in two double precision (64-bit) floating-point arrays and writes the result to the second array.</summary>
		/// <exception cref="System.NullReferenceException">If xArray or yArray is null.</exception>
		/// <exception cref="System.DataMisalignedException">If xArray or yArray is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, yOffset is negative, yOffset + length exceeds the length of yArray, or length is negative.</exception>
		public static unsafe void Subtract_V64fIV64f_IV64f(double[] xArray, int xOffset, double[] yArray, int yOffset, int length)
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
					Subtract_V64fIV64f_IV64f(x, y, length);
				}
			}
		}


		/// <summary>Subtracts a constant from signed 8-bit integer array elements and writes the result to the same array.</summary>
		/// <exception cref="System.NullReferenceException">If xArray is null.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, or length is negative.</exception>
		public static unsafe void Subtract_IV8sS8s_IV8s(sbyte[] xArray, int xOffset, sbyte y, int length)
		{
			if (xOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (xOffset + length > xArray.Length)
				throw new System.IndexOutOfRangeException();

			if (length < 0)
				throw new System.ArgumentException();

			fixed (sbyte* x = &xArray[xOffset])
			{
				Subtract_IV8sS8s_IV8s(x, y, length);
			}
		}


		/// <summary>Subtracts a constant from signed 16-bit integer array elements and writes the result to the same array.</summary>
		/// <exception cref="System.NullReferenceException">If xArray is null.</exception>
		/// <exception cref="System.DataMisalignedException">If xArray is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, or length is negative.</exception>
		public static unsafe void Subtract_IV16sS16s_IV16s(short[] xArray, int xOffset, short y, int length)
		{
			if (xOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (xOffset + length > xArray.Length)
				throw new System.IndexOutOfRangeException();

			if (length < 0)
				throw new System.ArgumentException();

			fixed (short* x = &xArray[xOffset])
			{
				Subtract_IV16sS16s_IV16s(x, y, length);
			}
		}


		/// <summary>Subtracts a constant from signed 32-bit integer array elements and writes the result to the same array.</summary>
		/// <exception cref="System.NullReferenceException">If xArray is null.</exception>
		/// <exception cref="System.DataMisalignedException">If xArray is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, or length is negative.</exception>
		public static unsafe void Subtract_IV32sS32s_IV32s(int[] xArray, int xOffset, int y, int length)
		{
			if (xOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (xOffset + length > xArray.Length)
				throw new System.IndexOutOfRangeException();

			if (length < 0)
				throw new System.ArgumentException();

			fixed (int* x = &xArray[xOffset])
			{
				Subtract_IV32sS32s_IV32s(x, y, length);
			}
		}


		/// <summary>Subtracts a constant from signed 64-bit integer array elements and writes the result to the same array.</summary>
		/// <exception cref="System.NullReferenceException">If xArray is null.</exception>
		/// <exception cref="System.DataMisalignedException">If xArray is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, or length is negative.</exception>
		public static unsafe void Subtract_IV64sS64s_IV64s(long[] xArray, int xOffset, long y, int length)
		{
			if (xOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (xOffset + length > xArray.Length)
				throw new System.IndexOutOfRangeException();

			if (length < 0)
				throw new System.ArgumentException();

			fixed (long* x = &xArray[xOffset])
			{
				Subtract_IV64sS64s_IV64s(x, y, length);
			}
		}


		/// <summary>Subtracts a constant from single precision (32-bit) floating-point array elements and writes the result to the same array.</summary>
		/// <exception cref="System.NullReferenceException">If xArray is null.</exception>
		/// <exception cref="System.DataMisalignedException">If xArray is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, or length is negative.</exception>
		public static unsafe void Subtract_IV32fS32f_IV32f(float[] xArray, int xOffset, float y, int length)
		{
			if (xOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (xOffset + length > xArray.Length)
				throw new System.IndexOutOfRangeException();

			if (length < 0)
				throw new System.ArgumentException();

			fixed (float* x = &xArray[xOffset])
			{
				Subtract_IV32fS32f_IV32f(x, y, length);
			}
		}


		/// <summary>Subtracts a constant from double precision (64-bit) floating-point array elements and writes the result to the same array.</summary>
		/// <exception cref="System.NullReferenceException">If xArray is null.</exception>
		/// <exception cref="System.DataMisalignedException">If xArray is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, or length is negative.</exception>
		public static unsafe void Subtract_IV64fS64f_IV64f(double[] xArray, int xOffset, double y, int length)
		{
			if (xOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (xOffset + length > xArray.Length)
				throw new System.IndexOutOfRangeException();

			if (length < 0)
				throw new System.ArgumentException();

			fixed (double* x = &xArray[xOffset])
			{
				Subtract_IV64fS64f_IV64f(x, y, length);
			}
		}


		/// <summary>Subtracts signed 8-bit integer array elements from a constant and writes the result to the same array.</summary>
		/// <exception cref="System.NullReferenceException">If yArray is null.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If yOffset is negative, yOffset + length exceeds the length of yArray, or length is negative.</exception>
		public static unsafe void Subtract_S8sIV8s_IV8s(sbyte x, sbyte[] yArray, int yOffset, int length)
		{
			if (yOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (yOffset + length > yArray.Length)
				throw new System.IndexOutOfRangeException();

			if (length < 0)
				throw new System.ArgumentException();

			fixed (sbyte* y = &yArray[yOffset])
			{
				Subtract_S8sIV8s_IV8s(x, y, length);
			}
		}


		/// <summary>Subtracts signed 16-bit integer array elements from a constant and writes the result to the same array.</summary>
		/// <exception cref="System.NullReferenceException">If yArray is null.</exception>
		/// <exception cref="System.DataMisalignedException">If yArray is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If yOffset is negative, yOffset + length exceeds the length of yArray, or length is negative.</exception>
		public static unsafe void Subtract_S16sIV16s_IV16s(short x, short[] yArray, int yOffset, int length)
		{
			if (yOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (yOffset + length > yArray.Length)
				throw new System.IndexOutOfRangeException();

			if (length < 0)
				throw new System.ArgumentException();

			fixed (short* y = &yArray[yOffset])
			{
				Subtract_S16sIV16s_IV16s(x, y, length);
			}
		}


		/// <summary>Subtracts signed 32-bit integer array elements from a constant and writes the result to the same array.</summary>
		/// <exception cref="System.NullReferenceException">If yArray is null.</exception>
		/// <exception cref="System.DataMisalignedException">If yArray is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If yOffset is negative, yOffset + length exceeds the length of yArray, or length is negative.</exception>
		public static unsafe void Subtract_S32sIV32s_IV32s(int x, int[] yArray, int yOffset, int length)
		{
			if (yOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (yOffset + length > yArray.Length)
				throw new System.IndexOutOfRangeException();

			if (length < 0)
				throw new System.ArgumentException();

			fixed (int* y = &yArray[yOffset])
			{
				Subtract_S32sIV32s_IV32s(x, y, length);
			}
		}


		/// <summary>Subtracts signed 64-bit integer array elements from a constant and writes the result to the same array.</summary>
		/// <exception cref="System.NullReferenceException">If yArray is null.</exception>
		/// <exception cref="System.DataMisalignedException">If yArray is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If yOffset is negative, yOffset + length exceeds the length of yArray, or length is negative.</exception>
		public static unsafe void Subtract_S64sIV64s_IV64s(long x, long[] yArray, int yOffset, int length)
		{
			if (yOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (yOffset + length > yArray.Length)
				throw new System.IndexOutOfRangeException();

			if (length < 0)
				throw new System.ArgumentException();

			fixed (long* y = &yArray[yOffset])
			{
				Subtract_S64sIV64s_IV64s(x, y, length);
			}
		}


		/// <summary>Subtracts single precision (32-bit) floating-point array elements from a constant and writes the result to the same array.</summary>
		/// <exception cref="System.NullReferenceException">If yArray is null.</exception>
		/// <exception cref="System.DataMisalignedException">If yArray is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If yOffset is negative, yOffset + length exceeds the length of yArray, or length is negative.</exception>
		public static unsafe void Subtract_S32fIV32f_IV32f(float x, float[] yArray, int yOffset, int length)
		{
			if (yOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (yOffset + length > yArray.Length)
				throw new System.IndexOutOfRangeException();

			if (length < 0)
				throw new System.ArgumentException();

			fixed (float* y = &yArray[yOffset])
			{
				Subtract_S32fIV32f_IV32f(x, y, length);
			}
		}


		/// <summary>Subtracts double precision (64-bit) floating-point array elements from a constant and writes the result to the same array.</summary>
		/// <exception cref="System.NullReferenceException">If yArray is null.</exception>
		/// <exception cref="System.DataMisalignedException">If yArray is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If yOffset is negative, yOffset + length exceeds the length of yArray, or length is negative.</exception>
		public static unsafe void Subtract_S64fIV64f_IV64f(double x, double[] yArray, int yOffset, int length)
		{
			if (yOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (yOffset + length > yArray.Length)
				throw new System.IndexOutOfRangeException();

			if (length < 0)
				throw new System.ArgumentException();

			fixed (double* y = &yArray[yOffset])
			{
				Subtract_S64fIV64f_IV64f(x, y, length);
			}
		}


		/// <summary>Subtracts corresponding elements in two signed 8-bit integer arrays. Produces an array of signed 8-bit integer elements.</summary>
		/// <param name="x">Pointer to the minuend array of signed 8-bit integer elements.</param>
		/// <param name="y">Pointer to the subtrahend array of signed 8-bit integer elements.</param>
		/// <param name="diff">Pointer to the difference array of signed 8-bit integer elements.</param>
		/// <param name="length">Length of the arrays specified by x, y, and diff.</param>
		/// <exception cref="System.NullReferenceException">If x, y or diff is null.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		public static unsafe void Subtract_V8sV8s_V8s(sbyte* x, sbyte* y, sbyte* diff, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			Status status = yepCore_Subtract_V8sV8s_V8s(x, y, diff, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
		}


		/// <summary>Subtracts corresponding elements in two signed 8-bit integer arrays. Produces an array of signed 16-bit integer elements.</summary>
		/// <param name="x">Pointer to the minuend array of signed 8-bit integer elements.</param>
		/// <param name="y">Pointer to the subtrahend array of signed 8-bit integer elements.</param>
		/// <param name="diff">Pointer to the difference array of signed 16-bit integer elements.</param>
		/// <param name="length">Length of the arrays specified by x, y, and diff.</param>
		/// <exception cref="System.NullReferenceException">If x, y or diff is null.</exception>
		/// <exception cref="System.DataMisalignedException">If diff is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		public static unsafe void Subtract_V8sV8s_V16s(sbyte* x, sbyte* y, short* diff, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			Status status = yepCore_Subtract_V8sV8s_V16s(x, y, diff, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
		}


		/// <summary>Subtracts corresponding elements in two unsigned 8-bit integer arrays. Produces an array of unsigned 16-bit integer elements.</summary>
		/// <param name="x">Pointer to the minuend array of unsigned 8-bit integer elements.</param>
		/// <param name="y">Pointer to the subtrahend array of unsigned 8-bit integer elements.</param>
		/// <param name="diff">Pointer to the difference array of unsigned 16-bit integer elements.</param>
		/// <param name="length">Length of the arrays specified by x, y, and diff.</param>
		/// <exception cref="System.NullReferenceException">If x, y or diff is null.</exception>
		/// <exception cref="System.DataMisalignedException">If diff is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		public static unsafe void Subtract_V8uV8u_V16u(byte* x, byte* y, ushort* diff, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			Status status = yepCore_Subtract_V8uV8u_V16u(x, y, diff, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
		}


		/// <summary>Subtracts corresponding elements in two signed 16-bit integer arrays. Produces an array of signed 16-bit integer elements.</summary>
		/// <param name="x">Pointer to the minuend array of signed 16-bit integer elements.</param>
		/// <param name="y">Pointer to the subtrahend array of signed 16-bit integer elements.</param>
		/// <param name="diff">Pointer to the difference array of signed 16-bit integer elements.</param>
		/// <param name="length">Length of the arrays specified by x, y, and diff.</param>
		/// <exception cref="System.NullReferenceException">If x, y or diff is null.</exception>
		/// <exception cref="System.DataMisalignedException">If x, y or diff is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		public static unsafe void Subtract_V16sV16s_V16s(short* x, short* y, short* diff, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			Status status = yepCore_Subtract_V16sV16s_V16s(x, y, diff, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
		}


		/// <summary>Subtracts corresponding elements in two signed 16-bit integer arrays. Produces an array of signed 32-bit integer elements.</summary>
		/// <param name="x">Pointer to the minuend array of signed 16-bit integer elements.</param>
		/// <param name="y">Pointer to the subtrahend array of signed 16-bit integer elements.</param>
		/// <param name="diff">Pointer to the difference array of signed 32-bit integer elements.</param>
		/// <param name="length">Length of the arrays specified by x, y, and diff.</param>
		/// <exception cref="System.NullReferenceException">If x, y or diff is null.</exception>
		/// <exception cref="System.DataMisalignedException">If x, y or diff is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		public static unsafe void Subtract_V16sV16s_V32s(short* x, short* y, int* diff, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			Status status = yepCore_Subtract_V16sV16s_V32s(x, y, diff, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
		}


		/// <summary>Subtracts corresponding elements in two unsigned 16-bit integer arrays. Produces an array of unsigned 32-bit integer elements.</summary>
		/// <param name="x">Pointer to the minuend array of unsigned 16-bit integer elements.</param>
		/// <param name="y">Pointer to the subtrahend array of unsigned 16-bit integer elements.</param>
		/// <param name="diff">Pointer to the difference array of unsigned 32-bit integer elements.</param>
		/// <param name="length">Length of the arrays specified by x, y, and diff.</param>
		/// <exception cref="System.NullReferenceException">If x, y or diff is null.</exception>
		/// <exception cref="System.DataMisalignedException">If x, y or diff is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		public static unsafe void Subtract_V16uV16u_V32u(ushort* x, ushort* y, uint* diff, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			Status status = yepCore_Subtract_V16uV16u_V32u(x, y, diff, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
		}


		/// <summary>Subtracts corresponding elements in two signed 32-bit integer arrays. Produces an array of signed 32-bit integer elements.</summary>
		/// <param name="x">Pointer to the minuend array of signed 32-bit integer elements.</param>
		/// <param name="y">Pointer to the subtrahend array of signed 32-bit integer elements.</param>
		/// <param name="diff">Pointer to the difference array of signed 32-bit integer elements.</param>
		/// <param name="length">Length of the arrays specified by x, y, and diff.</param>
		/// <exception cref="System.NullReferenceException">If x, y or diff is null.</exception>
		/// <exception cref="System.DataMisalignedException">If x, y or diff is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		public static unsafe void Subtract_V32sV32s_V32s(int* x, int* y, int* diff, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			Status status = yepCore_Subtract_V32sV32s_V32s(x, y, diff, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
		}


		/// <summary>Subtracts corresponding elements in two signed 32-bit integer arrays. Produces an array of signed 64-bit integer elements.</summary>
		/// <param name="x">Pointer to the minuend array of signed 32-bit integer elements.</param>
		/// <param name="y">Pointer to the subtrahend array of signed 32-bit integer elements.</param>
		/// <param name="diff">Pointer to the difference array of signed 64-bit integer elements.</param>
		/// <param name="length">Length of the arrays specified by x, y, and diff.</param>
		/// <exception cref="System.NullReferenceException">If x, y or diff is null.</exception>
		/// <exception cref="System.DataMisalignedException">If x, y or diff is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		public static unsafe void Subtract_V32sV32s_V64s(int* x, int* y, long* diff, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			Status status = yepCore_Subtract_V32sV32s_V64s(x, y, diff, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
		}


		/// <summary>Subtracts corresponding elements in two unsigned 32-bit integer arrays. Produces an array of unsigned 64-bit integer elements.</summary>
		/// <param name="x">Pointer to the minuend array of unsigned 32-bit integer elements.</param>
		/// <param name="y">Pointer to the subtrahend array of unsigned 32-bit integer elements.</param>
		/// <param name="diff">Pointer to the difference array of unsigned 64-bit integer elements.</param>
		/// <param name="length">Length of the arrays specified by x, y, and diff.</param>
		/// <exception cref="System.NullReferenceException">If x, y or diff is null.</exception>
		/// <exception cref="System.DataMisalignedException">If x, y or diff is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		public static unsafe void Subtract_V32uV32u_V64u(uint* x, uint* y, ulong* diff, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			Status status = yepCore_Subtract_V32uV32u_V64u(x, y, diff, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
		}


		/// <summary>Subtracts corresponding elements in two signed 64-bit integer arrays. Produces an array of signed 64-bit integer elements.</summary>
		/// <param name="x">Pointer to the minuend array of signed 64-bit integer elements.</param>
		/// <param name="y">Pointer to the subtrahend array of signed 64-bit integer elements.</param>
		/// <param name="diff">Pointer to the difference array of signed 64-bit integer elements.</param>
		/// <param name="length">Length of the arrays specified by x, y, and diff.</param>
		/// <exception cref="System.NullReferenceException">If x, y or diff is null.</exception>
		/// <exception cref="System.DataMisalignedException">If x, y or diff is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		public static unsafe void Subtract_V64sV64s_V64s(long* x, long* y, long* diff, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			Status status = yepCore_Subtract_V64sV64s_V64s(x, y, diff, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
		}


		/// <summary>Subtracts corresponding elements in two single precision (32-bit) floating-point arrays. Produces an array of single precision (32-bit) floating-point elements.</summary>
		/// <param name="x">Pointer to the minuend array of single precision (32-bit) floating-point elements.</param>
		/// <param name="y">Pointer to the subtrahend array of single precision (32-bit) floating-point elements.</param>
		/// <param name="diff">Pointer to the difference array of single precision (32-bit) floating-point elements.</param>
		/// <param name="length">Length of the arrays specified by x, y, and diff.</param>
		/// <exception cref="System.NullReferenceException">If x, y or diff is null.</exception>
		/// <exception cref="System.DataMisalignedException">If x, y or diff is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		public static unsafe void Subtract_V32fV32f_V32f(float* x, float* y, float* diff, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			Status status = yepCore_Subtract_V32fV32f_V32f(x, y, diff, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
		}


		/// <summary>Subtracts corresponding elements in two double precision (64-bit) floating-point arrays. Produces an array of double precision (64-bit) floating-point elements.</summary>
		/// <param name="x">Pointer to the minuend array of double precision (64-bit) floating-point elements.</param>
		/// <param name="y">Pointer to the subtrahend array of double precision (64-bit) floating-point elements.</param>
		/// <param name="diff">Pointer to the difference array of double precision (64-bit) floating-point elements.</param>
		/// <param name="length">Length of the arrays specified by x, y, and diff.</param>
		/// <exception cref="System.NullReferenceException">If x, y or diff is null.</exception>
		/// <exception cref="System.DataMisalignedException">If x, y or diff is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		public static unsafe void Subtract_V64fV64f_V64f(double* x, double* y, double* diff, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			Status status = yepCore_Subtract_V64fV64f_V64f(x, y, diff, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
		}


		/// <summary>Subtracts a constant from signed 8-bit integer array elements. Produces an array of signed 8-bit integer elements.</summary>
		/// <param name="x">Pointer to the minuend array of signed 8-bit integer elements.</param>
		/// <param name="y">The signed 8-bit integer constant to be subtracted.</param>
		/// <param name="diff">Pointer to the difference array of signed 8-bit integer elements.</param>
		/// <param name="length">Length of the arrays specified by x and diff.</param>
		/// <exception cref="System.NullReferenceException">If x or diff is null.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		public static unsafe void Subtract_V8sS8s_V8s(sbyte* x, sbyte y, sbyte* diff, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			Status status = yepCore_Subtract_V8sS8s_V8s(x, y, diff, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
		}


		/// <summary>Subtracts a constant from signed 8-bit integer array elements. Produces an array of signed 16-bit integer elements.</summary>
		/// <param name="x">Pointer to the minuend array of signed 8-bit integer elements.</param>
		/// <param name="y">The signed 8-bit integer constant to be subtracted.</param>
		/// <param name="diff">Pointer to the difference array of signed 16-bit integer elements.</param>
		/// <param name="length">Length of the arrays specified by x and diff.</param>
		/// <exception cref="System.NullReferenceException">If x or diff is null.</exception>
		/// <exception cref="System.DataMisalignedException">If diff is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		public static unsafe void Subtract_V8sS8s_V16s(sbyte* x, sbyte y, short* diff, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			Status status = yepCore_Subtract_V8sS8s_V16s(x, y, diff, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
		}


		/// <summary>Subtracts a constant from unsigned 8-bit integer array elements. Produces an array of unsigned 16-bit integer elements.</summary>
		/// <param name="x">Pointer to the minuend array of unsigned 8-bit integer elements.</param>
		/// <param name="y">The unsigned 8-bit integer constant to be subtracted.</param>
		/// <param name="diff">Pointer to the difference array of unsigned 16-bit integer elements.</param>
		/// <param name="length">Length of the arrays specified by x and diff.</param>
		/// <exception cref="System.NullReferenceException">If x or diff is null.</exception>
		/// <exception cref="System.DataMisalignedException">If diff is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		public static unsafe void Subtract_V8uS8u_V16u(byte* x, byte y, ushort* diff, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			Status status = yepCore_Subtract_V8uS8u_V16u(x, y, diff, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
		}


		/// <summary>Subtracts a constant from signed 16-bit integer array elements. Produces an array of signed 16-bit integer elements.</summary>
		/// <param name="x">Pointer to the minuend array of signed 16-bit integer elements.</param>
		/// <param name="y">The signed 16-bit integer constant to be subtracted.</param>
		/// <param name="diff">Pointer to the difference array of signed 16-bit integer elements.</param>
		/// <param name="length">Length of the arrays specified by x and diff.</param>
		/// <exception cref="System.NullReferenceException">If x or diff is null.</exception>
		/// <exception cref="System.DataMisalignedException">If x or diff is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		public static unsafe void Subtract_V16sS16s_V16s(short* x, short y, short* diff, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			Status status = yepCore_Subtract_V16sS16s_V16s(x, y, diff, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
		}


		/// <summary>Subtracts a constant from signed 16-bit integer array elements. Produces an array of signed 32-bit integer elements.</summary>
		/// <param name="x">Pointer to the minuend array of signed 16-bit integer elements.</param>
		/// <param name="y">The signed 16-bit integer constant to be subtracted.</param>
		/// <param name="diff">Pointer to the difference array of signed 32-bit integer elements.</param>
		/// <param name="length">Length of the arrays specified by x and diff.</param>
		/// <exception cref="System.NullReferenceException">If x or diff is null.</exception>
		/// <exception cref="System.DataMisalignedException">If x or diff is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		public static unsafe void Subtract_V16sS16s_V32s(short* x, short y, int* diff, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			Status status = yepCore_Subtract_V16sS16s_V32s(x, y, diff, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
		}


		/// <summary>Subtracts a constant from unsigned 16-bit integer array elements. Produces an array of unsigned 32-bit integer elements.</summary>
		/// <param name="x">Pointer to the minuend array of unsigned 16-bit integer elements.</param>
		/// <param name="y">The unsigned 16-bit integer constant to be subtracted.</param>
		/// <param name="diff">Pointer to the difference array of unsigned 32-bit integer elements.</param>
		/// <param name="length">Length of the arrays specified by x and diff.</param>
		/// <exception cref="System.NullReferenceException">If x or diff is null.</exception>
		/// <exception cref="System.DataMisalignedException">If x or diff is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		public static unsafe void Subtract_V16uS16u_V32u(ushort* x, ushort y, uint* diff, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			Status status = yepCore_Subtract_V16uS16u_V32u(x, y, diff, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
		}


		/// <summary>Subtracts a constant from signed 32-bit integer array elements. Produces an array of signed 32-bit integer elements.</summary>
		/// <param name="x">Pointer to the minuend array of signed 32-bit integer elements.</param>
		/// <param name="y">The signed 32-bit integer constant to be subtracted.</param>
		/// <param name="diff">Pointer to the difference array of signed 32-bit integer elements.</param>
		/// <param name="length">Length of the arrays specified by x and diff.</param>
		/// <exception cref="System.NullReferenceException">If x or diff is null.</exception>
		/// <exception cref="System.DataMisalignedException">If x or diff is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		public static unsafe void Subtract_V32sS32s_V32s(int* x, int y, int* diff, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			Status status = yepCore_Subtract_V32sS32s_V32s(x, y, diff, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
		}


		/// <summary>Subtracts a constant from signed 32-bit integer array elements. Produces an array of signed 64-bit integer elements.</summary>
		/// <param name="x">Pointer to the minuend array of signed 32-bit integer elements.</param>
		/// <param name="y">The signed 32-bit integer constant to be subtracted.</param>
		/// <param name="diff">Pointer to the difference array of signed 64-bit integer elements.</param>
		/// <param name="length">Length of the arrays specified by x and diff.</param>
		/// <exception cref="System.NullReferenceException">If x or diff is null.</exception>
		/// <exception cref="System.DataMisalignedException">If x or diff is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		public static unsafe void Subtract_V32sS32s_V64s(int* x, int y, long* diff, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			Status status = yepCore_Subtract_V32sS32s_V64s(x, y, diff, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
		}


		/// <summary>Subtracts a constant from unsigned 32-bit integer array elements. Produces an array of unsigned 64-bit integer elements.</summary>
		/// <param name="x">Pointer to the minuend array of unsigned 32-bit integer elements.</param>
		/// <param name="y">The unsigned 32-bit integer constant to be subtracted.</param>
		/// <param name="diff">Pointer to the difference array of unsigned 64-bit integer elements.</param>
		/// <param name="length">Length of the arrays specified by x and diff.</param>
		/// <exception cref="System.NullReferenceException">If x or diff is null.</exception>
		/// <exception cref="System.DataMisalignedException">If x or diff is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		public static unsafe void Subtract_V32uS32u_V64u(uint* x, uint y, ulong* diff, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			Status status = yepCore_Subtract_V32uS32u_V64u(x, y, diff, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
		}


		/// <summary>Subtracts a constant from signed 64-bit integer array elements. Produces an array of signed 64-bit integer elements.</summary>
		/// <param name="x">Pointer to the minuend array of signed 64-bit integer elements.</param>
		/// <param name="y">The signed 64-bit integer constant to be subtracted.</param>
		/// <param name="diff">Pointer to the difference array of signed 64-bit integer elements.</param>
		/// <param name="length">Length of the arrays specified by x and diff.</param>
		/// <exception cref="System.NullReferenceException">If x or diff is null.</exception>
		/// <exception cref="System.DataMisalignedException">If x or diff is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		public static unsafe void Subtract_V64sS64s_V64s(long* x, long y, long* diff, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			Status status = yepCore_Subtract_V64sS64s_V64s(x, y, diff, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
		}


		/// <summary>Subtracts a constant from single precision (32-bit) floating-point array elements. Produces an array of single precision (32-bit) floating-point elements.</summary>
		/// <param name="x">Pointer to the minuend array of single precision (32-bit) floating-point elements.</param>
		/// <param name="y">The single precision (32-bit) floating-point constant to be subtracted.</param>
		/// <param name="diff">Pointer to the difference array of single precision (32-bit) floating-point elements.</param>
		/// <param name="length">Length of the arrays specified by x and diff.</param>
		/// <exception cref="System.NullReferenceException">If x or diff is null.</exception>
		/// <exception cref="System.DataMisalignedException">If x or diff is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		public static unsafe void Subtract_V32fS32f_V32f(float* x, float y, float* diff, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			Status status = yepCore_Subtract_V32fS32f_V32f(x, y, diff, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
		}


		/// <summary>Subtracts a constant from double precision (64-bit) floating-point array elements. Produces an array of double precision (64-bit) floating-point elements.</summary>
		/// <param name="x">Pointer to the minuend array of double precision (64-bit) floating-point elements.</param>
		/// <param name="y">The double precision (64-bit) floating-point constant to be subtracted.</param>
		/// <param name="diff">Pointer to the difference array of double precision (64-bit) floating-point elements.</param>
		/// <param name="length">Length of the arrays specified by x and diff.</param>
		/// <exception cref="System.NullReferenceException">If x or diff is null.</exception>
		/// <exception cref="System.DataMisalignedException">If x or diff is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		public static unsafe void Subtract_V64fS64f_V64f(double* x, double y, double* diff, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			Status status = yepCore_Subtract_V64fS64f_V64f(x, y, diff, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
		}


		/// <summary>Subtracts signed 8-bit integer array elements from a constant. Produces an array of signed 8-bit integer elements.</summary>
		/// <param name="x">The signed 8-bit integer constant to be subtracted from.</param>
		/// <param name="y">Pointer to the subtrahend array of signed 8-bit integer elements.</param>
		/// <param name="diff">Pointer to the difference array of signed 8-bit integer elements.</param>
		/// <param name="length">Length of the arrays specified by y and diff.</param>
		/// <exception cref="System.NullReferenceException">If y or diff is null.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		public static unsafe void Subtract_S8sV8s_V8s(sbyte x, sbyte* y, sbyte* diff, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			Status status = yepCore_Subtract_S8sV8s_V8s(x, y, diff, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
		}


		/// <summary>Subtracts signed 8-bit integer array elements from a constant. Produces an array of signed 16-bit integer elements.</summary>
		/// <param name="x">The signed 8-bit integer constant to be subtracted from.</param>
		/// <param name="y">Pointer to the subtrahend array of signed 8-bit integer elements.</param>
		/// <param name="diff">Pointer to the difference array of signed 16-bit integer elements.</param>
		/// <param name="length">Length of the arrays specified by y and diff.</param>
		/// <exception cref="System.NullReferenceException">If y or diff is null.</exception>
		/// <exception cref="System.DataMisalignedException">If diff is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		public static unsafe void Subtract_S8sV8s_V16s(sbyte x, sbyte* y, short* diff, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			Status status = yepCore_Subtract_S8sV8s_V16s(x, y, diff, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
		}


		/// <summary>Subtracts unsigned 8-bit integer array elements from a constant. Produces an array of unsigned 16-bit integer elements.</summary>
		/// <param name="x">The unsigned 8-bit integer constant to be subtracted from.</param>
		/// <param name="y">Pointer to the subtrahend array of unsigned 8-bit integer elements.</param>
		/// <param name="diff">Pointer to the difference array of unsigned 16-bit integer elements.</param>
		/// <param name="length">Length of the arrays specified by y and diff.</param>
		/// <exception cref="System.NullReferenceException">If y or diff is null.</exception>
		/// <exception cref="System.DataMisalignedException">If diff is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		public static unsafe void Subtract_S8uV8u_V16u(byte x, byte* y, ushort* diff, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			Status status = yepCore_Subtract_S8uV8u_V16u(x, y, diff, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
		}


		/// <summary>Subtracts signed 16-bit integer array elements from a constant. Produces an array of signed 16-bit integer elements.</summary>
		/// <param name="x">The signed 16-bit integer constant to be subtracted from.</param>
		/// <param name="y">Pointer to the subtrahend array of signed 16-bit integer elements.</param>
		/// <param name="diff">Pointer to the difference array of signed 16-bit integer elements.</param>
		/// <param name="length">Length of the arrays specified by y and diff.</param>
		/// <exception cref="System.NullReferenceException">If y or diff is null.</exception>
		/// <exception cref="System.DataMisalignedException">If y or diff is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		public static unsafe void Subtract_S16sV16s_V16s(short x, short* y, short* diff, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			Status status = yepCore_Subtract_S16sV16s_V16s(x, y, diff, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
		}


		/// <summary>Subtracts signed 16-bit integer array elements from a constant. Produces an array of signed 32-bit integer elements.</summary>
		/// <param name="x">The signed 16-bit integer constant to be subtracted from.</param>
		/// <param name="y">Pointer to the subtrahend array of signed 16-bit integer elements.</param>
		/// <param name="diff">Pointer to the difference array of signed 32-bit integer elements.</param>
		/// <param name="length">Length of the arrays specified by y and diff.</param>
		/// <exception cref="System.NullReferenceException">If y or diff is null.</exception>
		/// <exception cref="System.DataMisalignedException">If y or diff is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		public static unsafe void Subtract_S16sV16s_V32s(short x, short* y, int* diff, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			Status status = yepCore_Subtract_S16sV16s_V32s(x, y, diff, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
		}


		/// <summary>Subtracts unsigned 16-bit integer array elements from a constant. Produces an array of unsigned 32-bit integer elements.</summary>
		/// <param name="x">The unsigned 16-bit integer constant to be subtracted from.</param>
		/// <param name="y">Pointer to the subtrahend array of unsigned 16-bit integer elements.</param>
		/// <param name="diff">Pointer to the difference array of unsigned 32-bit integer elements.</param>
		/// <param name="length">Length of the arrays specified by y and diff.</param>
		/// <exception cref="System.NullReferenceException">If y or diff is null.</exception>
		/// <exception cref="System.DataMisalignedException">If y or diff is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		public static unsafe void Subtract_S16uV16u_V32u(ushort x, ushort* y, uint* diff, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			Status status = yepCore_Subtract_S16uV16u_V32u(x, y, diff, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
		}


		/// <summary>Subtracts signed 32-bit integer array elements from a constant. Produces an array of signed 32-bit integer elements.</summary>
		/// <param name="x">The signed 32-bit integer constant to be subtracted from.</param>
		/// <param name="y">Pointer to the subtrahend array of signed 32-bit integer elements.</param>
		/// <param name="diff">Pointer to the difference array of signed 32-bit integer elements.</param>
		/// <param name="length">Length of the arrays specified by y and diff.</param>
		/// <exception cref="System.NullReferenceException">If y or diff is null.</exception>
		/// <exception cref="System.DataMisalignedException">If y or diff is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		public static unsafe void Subtract_S32sV32s_V32s(int x, int* y, int* diff, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			Status status = yepCore_Subtract_S32sV32s_V32s(x, y, diff, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
		}


		/// <summary>Subtracts signed 32-bit integer array elements from a constant. Produces an array of signed 64-bit integer elements.</summary>
		/// <param name="x">The signed 32-bit integer constant to be subtracted from.</param>
		/// <param name="y">Pointer to the subtrahend array of signed 32-bit integer elements.</param>
		/// <param name="diff">Pointer to the difference array of signed 64-bit integer elements.</param>
		/// <param name="length">Length of the arrays specified by y and diff.</param>
		/// <exception cref="System.NullReferenceException">If y or diff is null.</exception>
		/// <exception cref="System.DataMisalignedException">If y or diff is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		public static unsafe void Subtract_S32sV32s_V64s(int x, int* y, long* diff, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			Status status = yepCore_Subtract_S32sV32s_V64s(x, y, diff, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
		}


		/// <summary>Subtracts unsigned 32-bit integer array elements from a constant. Produces an array of unsigned 64-bit integer elements.</summary>
		/// <param name="x">The unsigned 32-bit integer constant to be subtracted from.</param>
		/// <param name="y">Pointer to the subtrahend array of unsigned 32-bit integer elements.</param>
		/// <param name="diff">Pointer to the difference array of unsigned 64-bit integer elements.</param>
		/// <param name="length">Length of the arrays specified by y and diff.</param>
		/// <exception cref="System.NullReferenceException">If y or diff is null.</exception>
		/// <exception cref="System.DataMisalignedException">If y or diff is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		public static unsafe void Subtract_S32uV32u_V64u(uint x, uint* y, ulong* diff, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			Status status = yepCore_Subtract_S32uV32u_V64u(x, y, diff, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
		}


		/// <summary>Subtracts signed 64-bit integer array elements from a constant. Produces an array of signed 64-bit integer elements.</summary>
		/// <param name="x">The signed 64-bit integer constant to be subtracted from.</param>
		/// <param name="y">Pointer to the subtrahend array of signed 64-bit integer elements.</param>
		/// <param name="diff">Pointer to the difference array of signed 64-bit integer elements.</param>
		/// <param name="length">Length of the arrays specified by y and diff.</param>
		/// <exception cref="System.NullReferenceException">If y or diff is null.</exception>
		/// <exception cref="System.DataMisalignedException">If y or diff is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		public static unsafe void Subtract_S64sV64s_V64s(long x, long* y, long* diff, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			Status status = yepCore_Subtract_S64sV64s_V64s(x, y, diff, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
		}


		/// <summary>Subtracts single precision (32-bit) floating-point array elements from a constant. Produces an array of single precision (32-bit) floating-point elements.</summary>
		/// <param name="x">The single precision (32-bit) floating-point constant to be subtracted from.</param>
		/// <param name="y">Pointer to the subtrahend array of single precision (32-bit) floating-point elements.</param>
		/// <param name="diff">Pointer to the difference array of single precision (32-bit) floating-point elements.</param>
		/// <param name="length">Length of the arrays specified by y and diff.</param>
		/// <exception cref="System.NullReferenceException">If y or diff is null.</exception>
		/// <exception cref="System.DataMisalignedException">If y or diff is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		public static unsafe void Subtract_S32fV32f_V32f(float x, float* y, float* diff, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			Status status = yepCore_Subtract_S32fV32f_V32f(x, y, diff, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
		}


		/// <summary>Subtracts double precision (64-bit) floating-point array elements from a constant. Produces an array of double precision (64-bit) floating-point elements.</summary>
		/// <param name="x">The double precision (64-bit) floating-point constant to be subtracted from.</param>
		/// <param name="y">Pointer to the subtrahend array of double precision (64-bit) floating-point elements.</param>
		/// <param name="diff">Pointer to the difference array of double precision (64-bit) floating-point elements.</param>
		/// <param name="length">Length of the arrays specified by y and diff.</param>
		/// <exception cref="System.NullReferenceException">If y or diff is null.</exception>
		/// <exception cref="System.DataMisalignedException">If y or diff is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		public static unsafe void Subtract_S64fV64f_V64f(double x, double* y, double* diff, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			Status status = yepCore_Subtract_S64fV64f_V64f(x, y, diff, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
		}


		/// <summary>Subtracts corresponding elements in two signed 8-bit integer arrays and writes the result to the first array.</summary>
		/// <param name="x">Pointer to the minuend array of signed 8-bit integer elements.</param>
		/// <param name="y">Pointer to the subtrahend array of signed 8-bit integer elements.</param>
		/// <param name="length">Length of the arrays specified by x and y.</param>
		/// <exception cref="System.NullReferenceException">If x or y is null.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		public static unsafe void Subtract_IV8sV8s_IV8s(sbyte* x, sbyte* y, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			Status status = yepCore_Subtract_IV8sV8s_IV8s(x, y, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
		}


		/// <summary>Subtracts corresponding elements in two signed 16-bit integer arrays and writes the result to the first array.</summary>
		/// <param name="x">Pointer to the minuend array of signed 16-bit integer elements.</param>
		/// <param name="y">Pointer to the subtrahend array of signed 16-bit integer elements.</param>
		/// <param name="length">Length of the arrays specified by x and y.</param>
		/// <exception cref="System.NullReferenceException">If x or y is null.</exception>
		/// <exception cref="System.DataMisalignedException">If x or y is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		public static unsafe void Subtract_IV16sV16s_IV16s(short* x, short* y, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			Status status = yepCore_Subtract_IV16sV16s_IV16s(x, y, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
		}


		/// <summary>Subtracts corresponding elements in two signed 32-bit integer arrays and writes the result to the first array.</summary>
		/// <param name="x">Pointer to the minuend array of signed 32-bit integer elements.</param>
		/// <param name="y">Pointer to the subtrahend array of signed 32-bit integer elements.</param>
		/// <param name="length">Length of the arrays specified by x and y.</param>
		/// <exception cref="System.NullReferenceException">If x or y is null.</exception>
		/// <exception cref="System.DataMisalignedException">If x or y is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		public static unsafe void Subtract_IV32sV32s_IV32s(int* x, int* y, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			Status status = yepCore_Subtract_IV32sV32s_IV32s(x, y, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
		}


		/// <summary>Subtracts corresponding elements in two signed 64-bit integer arrays and writes the result to the first array.</summary>
		/// <param name="x">Pointer to the minuend array of signed 64-bit integer elements.</param>
		/// <param name="y">Pointer to the subtrahend array of signed 64-bit integer elements.</param>
		/// <param name="length">Length of the arrays specified by x and y.</param>
		/// <exception cref="System.NullReferenceException">If x or y is null.</exception>
		/// <exception cref="System.DataMisalignedException">If x or y is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		public static unsafe void Subtract_IV64sV64s_IV64s(long* x, long* y, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			Status status = yepCore_Subtract_IV64sV64s_IV64s(x, y, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
		}


		/// <summary>Subtracts corresponding elements in two single precision (32-bit) floating-point arrays and writes the result to the first array.</summary>
		/// <param name="x">Pointer to the minuend array of single precision (32-bit) floating-point elements.</param>
		/// <param name="y">Pointer to the subtrahend array of single precision (32-bit) floating-point elements.</param>
		/// <param name="length">Length of the arrays specified by x and y.</param>
		/// <exception cref="System.NullReferenceException">If x or y is null.</exception>
		/// <exception cref="System.DataMisalignedException">If x or y is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		public static unsafe void Subtract_IV32fV32f_IV32f(float* x, float* y, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			Status status = yepCore_Subtract_IV32fV32f_IV32f(x, y, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
		}


		/// <summary>Subtracts corresponding elements in two double precision (64-bit) floating-point arrays and writes the result to the first array.</summary>
		/// <param name="x">Pointer to the minuend array of double precision (64-bit) floating-point elements.</param>
		/// <param name="y">Pointer to the subtrahend array of double precision (64-bit) floating-point elements.</param>
		/// <param name="length">Length of the arrays specified by x and y.</param>
		/// <exception cref="System.NullReferenceException">If x or y is null.</exception>
		/// <exception cref="System.DataMisalignedException">If x or y is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		public static unsafe void Subtract_IV64fV64f_IV64f(double* x, double* y, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			Status status = yepCore_Subtract_IV64fV64f_IV64f(x, y, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
		}


		/// <summary>Subtracts corresponding elements in two signed 8-bit integer arrays and writes the result to the second array.</summary>
		/// <param name="x">Pointer to the minuend array of signed 8-bit integer elements.</param>
		/// <param name="y">Pointer to the subtrahend array of signed 8-bit integer elements.</param>
		/// <param name="length">Length of the arrays specified by x and y.</param>
		/// <exception cref="System.NullReferenceException">If x or y is null.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		public static unsafe void Subtract_V8sIV8s_IV8s(sbyte* x, sbyte* y, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			Status status = yepCore_Subtract_V8sIV8s_IV8s(x, y, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
		}


		/// <summary>Subtracts corresponding elements in two signed 16-bit integer arrays and writes the result to the second array.</summary>
		/// <param name="x">Pointer to the minuend array of signed 16-bit integer elements.</param>
		/// <param name="y">Pointer to the subtrahend array of signed 16-bit integer elements.</param>
		/// <param name="length">Length of the arrays specified by x and y.</param>
		/// <exception cref="System.NullReferenceException">If x or y is null.</exception>
		/// <exception cref="System.DataMisalignedException">If x or y is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		public static unsafe void Subtract_V16sIV16s_IV16s(short* x, short* y, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			Status status = yepCore_Subtract_V16sIV16s_IV16s(x, y, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
		}


		/// <summary>Subtracts corresponding elements in two signed 32-bit integer arrays and writes the result to the second array.</summary>
		/// <param name="x">Pointer to the minuend array of signed 32-bit integer elements.</param>
		/// <param name="y">Pointer to the subtrahend array of signed 32-bit integer elements.</param>
		/// <param name="length">Length of the arrays specified by x and y.</param>
		/// <exception cref="System.NullReferenceException">If x or y is null.</exception>
		/// <exception cref="System.DataMisalignedException">If x or y is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		public static unsafe void Subtract_V32sIV32s_IV32s(int* x, int* y, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			Status status = yepCore_Subtract_V32sIV32s_IV32s(x, y, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
		}


		/// <summary>Subtracts corresponding elements in two signed 64-bit integer arrays and writes the result to the second array.</summary>
		/// <param name="x">Pointer to the minuend array of signed 64-bit integer elements.</param>
		/// <param name="y">Pointer to the subtrahend array of signed 64-bit integer elements.</param>
		/// <param name="length">Length of the arrays specified by x and y.</param>
		/// <exception cref="System.NullReferenceException">If x or y is null.</exception>
		/// <exception cref="System.DataMisalignedException">If x or y is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		public static unsafe void Subtract_V64sIV64s_IV64s(long* x, long* y, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			Status status = yepCore_Subtract_V64sIV64s_IV64s(x, y, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
		}


		/// <summary>Subtracts corresponding elements in two single precision (32-bit) floating-point arrays and writes the result to the second array.</summary>
		/// <param name="x">Pointer to the minuend array of single precision (32-bit) floating-point elements.</param>
		/// <param name="y">Pointer to the subtrahend array of single precision (32-bit) floating-point elements.</param>
		/// <param name="length">Length of the arrays specified by x and y.</param>
		/// <exception cref="System.NullReferenceException">If x or y is null.</exception>
		/// <exception cref="System.DataMisalignedException">If x or y is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		public static unsafe void Subtract_V32fIV32f_IV32f(float* x, float* y, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			Status status = yepCore_Subtract_V32fIV32f_IV32f(x, y, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
		}


		/// <summary>Subtracts corresponding elements in two double precision (64-bit) floating-point arrays and writes the result to the second array.</summary>
		/// <param name="x">Pointer to the minuend array of double precision (64-bit) floating-point elements.</param>
		/// <param name="y">Pointer to the subtrahend array of double precision (64-bit) floating-point elements.</param>
		/// <param name="length">Length of the arrays specified by x and y.</param>
		/// <exception cref="System.NullReferenceException">If x or y is null.</exception>
		/// <exception cref="System.DataMisalignedException">If x or y is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		public static unsafe void Subtract_V64fIV64f_IV64f(double* x, double* y, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			Status status = yepCore_Subtract_V64fIV64f_IV64f(x, y, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
		}


		/// <summary>Subtracts a constant from signed 8-bit integer array elements and writes the result to the same array.</summary>
		/// <param name="x">Pointer to the minuend array of signed 8-bit integer elements.</param>
		/// <param name="y">The signed 8-bit integer constant to be subtracted.</param>
		/// <param name="length">Length of the array specified by x.</param>
		/// <exception cref="System.NullReferenceException">If x is null.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		public static unsafe void Subtract_IV8sS8s_IV8s(sbyte* x, sbyte y, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			Status status = yepCore_Subtract_IV8sS8s_IV8s(x, y, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
		}


		/// <summary>Subtracts a constant from signed 16-bit integer array elements and writes the result to the same array.</summary>
		/// <param name="x">Pointer to the minuend array of signed 16-bit integer elements.</param>
		/// <param name="y">The signed 16-bit integer constant to be subtracted.</param>
		/// <param name="length">Length of the array specified by x.</param>
		/// <exception cref="System.NullReferenceException">If x is null.</exception>
		/// <exception cref="System.DataMisalignedException">If x is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		public static unsafe void Subtract_IV16sS16s_IV16s(short* x, short y, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			Status status = yepCore_Subtract_IV16sS16s_IV16s(x, y, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
		}


		/// <summary>Subtracts a constant from signed 32-bit integer array elements and writes the result to the same array.</summary>
		/// <param name="x">Pointer to the minuend array of signed 32-bit integer elements.</param>
		/// <param name="y">The signed 32-bit integer constant to be subtracted.</param>
		/// <param name="length">Length of the array specified by x.</param>
		/// <exception cref="System.NullReferenceException">If x is null.</exception>
		/// <exception cref="System.DataMisalignedException">If x is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		public static unsafe void Subtract_IV32sS32s_IV32s(int* x, int y, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			Status status = yepCore_Subtract_IV32sS32s_IV32s(x, y, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
		}


		/// <summary>Subtracts a constant from signed 64-bit integer array elements and writes the result to the same array.</summary>
		/// <param name="x">Pointer to the minuend array of signed 64-bit integer elements.</param>
		/// <param name="y">The signed 64-bit integer constant to be subtracted.</param>
		/// <param name="length">Length of the array specified by x.</param>
		/// <exception cref="System.NullReferenceException">If x is null.</exception>
		/// <exception cref="System.DataMisalignedException">If x is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		public static unsafe void Subtract_IV64sS64s_IV64s(long* x, long y, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			Status status = yepCore_Subtract_IV64sS64s_IV64s(x, y, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
		}


		/// <summary>Subtracts a constant from single precision (32-bit) floating-point array elements and writes the result to the same array.</summary>
		/// <param name="x">Pointer to the minuend array of single precision (32-bit) floating-point elements.</param>
		/// <param name="y">The single precision (32-bit) floating-point constant to be subtracted.</param>
		/// <param name="length">Length of the array specified by x.</param>
		/// <exception cref="System.NullReferenceException">If x is null.</exception>
		/// <exception cref="System.DataMisalignedException">If x is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		public static unsafe void Subtract_IV32fS32f_IV32f(float* x, float y, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			Status status = yepCore_Subtract_IV32fS32f_IV32f(x, y, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
		}


		/// <summary>Subtracts a constant from double precision (64-bit) floating-point array elements and writes the result to the same array.</summary>
		/// <param name="x">Pointer to the minuend array of double precision (64-bit) floating-point elements.</param>
		/// <param name="y">The double precision (64-bit) floating-point constant to be subtracted.</param>
		/// <param name="length">Length of the array specified by x.</param>
		/// <exception cref="System.NullReferenceException">If x is null.</exception>
		/// <exception cref="System.DataMisalignedException">If x is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		public static unsafe void Subtract_IV64fS64f_IV64f(double* x, double y, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			Status status = yepCore_Subtract_IV64fS64f_IV64f(x, y, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
		}


		/// <summary>Subtracts signed 8-bit integer array elements from a constant and writes the result to the same array.</summary>
		/// <param name="x">The signed 8-bit integer constant to be subtracted from.</param>
		/// <param name="y">Pointer to the subtrahend array of signed 8-bit integer elements.</param>
		/// <param name="length">Length of the array specified by y.</param>
		/// <exception cref="System.NullReferenceException">If y is null.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		public static unsafe void Subtract_S8sIV8s_IV8s(sbyte x, sbyte* y, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			Status status = yepCore_Subtract_S8sIV8s_IV8s(x, y, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
		}


		/// <summary>Subtracts signed 16-bit integer array elements from a constant and writes the result to the same array.</summary>
		/// <param name="x">The signed 16-bit integer constant to be subtracted from.</param>
		/// <param name="y">Pointer to the subtrahend array of signed 16-bit integer elements.</param>
		/// <param name="length">Length of the array specified by y.</param>
		/// <exception cref="System.NullReferenceException">If y is null.</exception>
		/// <exception cref="System.DataMisalignedException">If y is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		public static unsafe void Subtract_S16sIV16s_IV16s(short x, short* y, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			Status status = yepCore_Subtract_S16sIV16s_IV16s(x, y, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
		}


		/// <summary>Subtracts signed 32-bit integer array elements from a constant and writes the result to the same array.</summary>
		/// <param name="x">The signed 32-bit integer constant to be subtracted from.</param>
		/// <param name="y">Pointer to the subtrahend array of signed 32-bit integer elements.</param>
		/// <param name="length">Length of the array specified by y.</param>
		/// <exception cref="System.NullReferenceException">If y is null.</exception>
		/// <exception cref="System.DataMisalignedException">If y is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		public static unsafe void Subtract_S32sIV32s_IV32s(int x, int* y, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			Status status = yepCore_Subtract_S32sIV32s_IV32s(x, y, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
		}


		/// <summary>Subtracts signed 64-bit integer array elements from a constant and writes the result to the same array.</summary>
		/// <param name="x">The signed 64-bit integer constant to be subtracted from.</param>
		/// <param name="y">Pointer to the subtrahend array of signed 64-bit integer elements.</param>
		/// <param name="length">Length of the array specified by y.</param>
		/// <exception cref="System.NullReferenceException">If y is null.</exception>
		/// <exception cref="System.DataMisalignedException">If y is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		public static unsafe void Subtract_S64sIV64s_IV64s(long x, long* y, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			Status status = yepCore_Subtract_S64sIV64s_IV64s(x, y, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
		}


		/// <summary>Subtracts single precision (32-bit) floating-point array elements from a constant and writes the result to the same array.</summary>
		/// <param name="x">The single precision (32-bit) floating-point constant to be subtracted from.</param>
		/// <param name="y">Pointer to the subtrahend array of single precision (32-bit) floating-point elements.</param>
		/// <param name="length">Length of the array specified by y.</param>
		/// <exception cref="System.NullReferenceException">If y is null.</exception>
		/// <exception cref="System.DataMisalignedException">If y is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		public static unsafe void Subtract_S32fIV32f_IV32f(float x, float* y, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			Status status = yepCore_Subtract_S32fIV32f_IV32f(x, y, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
		}


		/// <summary>Subtracts double precision (64-bit) floating-point array elements from a constant and writes the result to the same array.</summary>
		/// <param name="x">The double precision (64-bit) floating-point constant to be subtracted from.</param>
		/// <param name="y">Pointer to the subtrahend array of double precision (64-bit) floating-point elements.</param>
		/// <param name="length">Length of the array specified by y.</param>
		/// <exception cref="System.NullReferenceException">If y is null.</exception>
		/// <exception cref="System.DataMisalignedException">If y is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		public static unsafe void Subtract_S64fIV64f_IV64f(double x, double* y, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			Status status = yepCore_Subtract_S64fIV64f_IV64f(x, y, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
		}


		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepCore_Subtract_V8sV8s_V8s")]
		private static unsafe extern Status yepCore_Subtract_V8sV8s_V8s(sbyte* x, sbyte* y, sbyte* diff, System.UIntPtr length);

		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepCore_Subtract_V8sV8s_V16s")]
		private static unsafe extern Status yepCore_Subtract_V8sV8s_V16s(sbyte* x, sbyte* y, short* diff, System.UIntPtr length);

		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepCore_Subtract_V8uV8u_V16u")]
		private static unsafe extern Status yepCore_Subtract_V8uV8u_V16u(byte* x, byte* y, ushort* diff, System.UIntPtr length);

		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepCore_Subtract_V16sV16s_V16s")]
		private static unsafe extern Status yepCore_Subtract_V16sV16s_V16s(short* x, short* y, short* diff, System.UIntPtr length);

		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepCore_Subtract_V16sV16s_V32s")]
		private static unsafe extern Status yepCore_Subtract_V16sV16s_V32s(short* x, short* y, int* diff, System.UIntPtr length);

		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepCore_Subtract_V16uV16u_V32u")]
		private static unsafe extern Status yepCore_Subtract_V16uV16u_V32u(ushort* x, ushort* y, uint* diff, System.UIntPtr length);

		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepCore_Subtract_V32sV32s_V32s")]
		private static unsafe extern Status yepCore_Subtract_V32sV32s_V32s(int* x, int* y, int* diff, System.UIntPtr length);

		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepCore_Subtract_V32sV32s_V64s")]
		private static unsafe extern Status yepCore_Subtract_V32sV32s_V64s(int* x, int* y, long* diff, System.UIntPtr length);

		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepCore_Subtract_V32uV32u_V64u")]
		private static unsafe extern Status yepCore_Subtract_V32uV32u_V64u(uint* x, uint* y, ulong* diff, System.UIntPtr length);

		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepCore_Subtract_V64sV64s_V64s")]
		private static unsafe extern Status yepCore_Subtract_V64sV64s_V64s(long* x, long* y, long* diff, System.UIntPtr length);

		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepCore_Subtract_V32fV32f_V32f")]
		private static unsafe extern Status yepCore_Subtract_V32fV32f_V32f(float* x, float* y, float* diff, System.UIntPtr length);

		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepCore_Subtract_V64fV64f_V64f")]
		private static unsafe extern Status yepCore_Subtract_V64fV64f_V64f(double* x, double* y, double* diff, System.UIntPtr length);

		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepCore_Subtract_V8sS8s_V8s")]
		private static unsafe extern Status yepCore_Subtract_V8sS8s_V8s(sbyte* x, sbyte y, sbyte* diff, System.UIntPtr length);

		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepCore_Subtract_V8sS8s_V16s")]
		private static unsafe extern Status yepCore_Subtract_V8sS8s_V16s(sbyte* x, sbyte y, short* diff, System.UIntPtr length);

		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepCore_Subtract_V8uS8u_V16u")]
		private static unsafe extern Status yepCore_Subtract_V8uS8u_V16u(byte* x, byte y, ushort* diff, System.UIntPtr length);

		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepCore_Subtract_V16sS16s_V16s")]
		private static unsafe extern Status yepCore_Subtract_V16sS16s_V16s(short* x, short y, short* diff, System.UIntPtr length);

		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepCore_Subtract_V16sS16s_V32s")]
		private static unsafe extern Status yepCore_Subtract_V16sS16s_V32s(short* x, short y, int* diff, System.UIntPtr length);

		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepCore_Subtract_V16uS16u_V32u")]
		private static unsafe extern Status yepCore_Subtract_V16uS16u_V32u(ushort* x, ushort y, uint* diff, System.UIntPtr length);

		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepCore_Subtract_V32sS32s_V32s")]
		private static unsafe extern Status yepCore_Subtract_V32sS32s_V32s(int* x, int y, int* diff, System.UIntPtr length);

		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepCore_Subtract_V32sS32s_V64s")]
		private static unsafe extern Status yepCore_Subtract_V32sS32s_V64s(int* x, int y, long* diff, System.UIntPtr length);

		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepCore_Subtract_V32uS32u_V64u")]
		private static unsafe extern Status yepCore_Subtract_V32uS32u_V64u(uint* x, uint y, ulong* diff, System.UIntPtr length);

		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepCore_Subtract_V64sS64s_V64s")]
		private static unsafe extern Status yepCore_Subtract_V64sS64s_V64s(long* x, long y, long* diff, System.UIntPtr length);

		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepCore_Subtract_V32fS32f_V32f")]
		private static unsafe extern Status yepCore_Subtract_V32fS32f_V32f(float* x, float y, float* diff, System.UIntPtr length);

		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepCore_Subtract_V64fS64f_V64f")]
		private static unsafe extern Status yepCore_Subtract_V64fS64f_V64f(double* x, double y, double* diff, System.UIntPtr length);

		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepCore_Subtract_S8sV8s_V8s")]
		private static unsafe extern Status yepCore_Subtract_S8sV8s_V8s(sbyte x, sbyte* y, sbyte* diff, System.UIntPtr length);

		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepCore_Subtract_S8sV8s_V16s")]
		private static unsafe extern Status yepCore_Subtract_S8sV8s_V16s(sbyte x, sbyte* y, short* diff, System.UIntPtr length);

		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepCore_Subtract_S8uV8u_V16u")]
		private static unsafe extern Status yepCore_Subtract_S8uV8u_V16u(byte x, byte* y, ushort* diff, System.UIntPtr length);

		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepCore_Subtract_S16sV16s_V16s")]
		private static unsafe extern Status yepCore_Subtract_S16sV16s_V16s(short x, short* y, short* diff, System.UIntPtr length);

		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepCore_Subtract_S16sV16s_V32s")]
		private static unsafe extern Status yepCore_Subtract_S16sV16s_V32s(short x, short* y, int* diff, System.UIntPtr length);

		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepCore_Subtract_S16uV16u_V32u")]
		private static unsafe extern Status yepCore_Subtract_S16uV16u_V32u(ushort x, ushort* y, uint* diff, System.UIntPtr length);

		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepCore_Subtract_S32sV32s_V32s")]
		private static unsafe extern Status yepCore_Subtract_S32sV32s_V32s(int x, int* y, int* diff, System.UIntPtr length);

		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepCore_Subtract_S32sV32s_V64s")]
		private static unsafe extern Status yepCore_Subtract_S32sV32s_V64s(int x, int* y, long* diff, System.UIntPtr length);

		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepCore_Subtract_S32uV32u_V64u")]
		private static unsafe extern Status yepCore_Subtract_S32uV32u_V64u(uint x, uint* y, ulong* diff, System.UIntPtr length);

		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepCore_Subtract_S64sV64s_V64s")]
		private static unsafe extern Status yepCore_Subtract_S64sV64s_V64s(long x, long* y, long* diff, System.UIntPtr length);

		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepCore_Subtract_S32fV32f_V32f")]
		private static unsafe extern Status yepCore_Subtract_S32fV32f_V32f(float x, float* y, float* diff, System.UIntPtr length);

		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepCore_Subtract_S64fV64f_V64f")]
		private static unsafe extern Status yepCore_Subtract_S64fV64f_V64f(double x, double* y, double* diff, System.UIntPtr length);

		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepCore_Subtract_IV8sV8s_IV8s")]
		private static unsafe extern Status yepCore_Subtract_IV8sV8s_IV8s(sbyte* x, sbyte* y, System.UIntPtr length);

		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepCore_Subtract_IV16sV16s_IV16s")]
		private static unsafe extern Status yepCore_Subtract_IV16sV16s_IV16s(short* x, short* y, System.UIntPtr length);

		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepCore_Subtract_IV32sV32s_IV32s")]
		private static unsafe extern Status yepCore_Subtract_IV32sV32s_IV32s(int* x, int* y, System.UIntPtr length);

		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepCore_Subtract_IV64sV64s_IV64s")]
		private static unsafe extern Status yepCore_Subtract_IV64sV64s_IV64s(long* x, long* y, System.UIntPtr length);

		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepCore_Subtract_IV32fV32f_IV32f")]
		private static unsafe extern Status yepCore_Subtract_IV32fV32f_IV32f(float* x, float* y, System.UIntPtr length);

		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepCore_Subtract_IV64fV64f_IV64f")]
		private static unsafe extern Status yepCore_Subtract_IV64fV64f_IV64f(double* x, double* y, System.UIntPtr length);

		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepCore_Subtract_V8sIV8s_IV8s")]
		private static unsafe extern Status yepCore_Subtract_V8sIV8s_IV8s(sbyte* x, sbyte* y, System.UIntPtr length);

		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepCore_Subtract_V16sIV16s_IV16s")]
		private static unsafe extern Status yepCore_Subtract_V16sIV16s_IV16s(short* x, short* y, System.UIntPtr length);

		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepCore_Subtract_V32sIV32s_IV32s")]
		private static unsafe extern Status yepCore_Subtract_V32sIV32s_IV32s(int* x, int* y, System.UIntPtr length);

		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepCore_Subtract_V64sIV64s_IV64s")]
		private static unsafe extern Status yepCore_Subtract_V64sIV64s_IV64s(long* x, long* y, System.UIntPtr length);

		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepCore_Subtract_V32fIV32f_IV32f")]
		private static unsafe extern Status yepCore_Subtract_V32fIV32f_IV32f(float* x, float* y, System.UIntPtr length);

		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepCore_Subtract_V64fIV64f_IV64f")]
		private static unsafe extern Status yepCore_Subtract_V64fIV64f_IV64f(double* x, double* y, System.UIntPtr length);

		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepCore_Subtract_IV8sS8s_IV8s")]
		private static unsafe extern Status yepCore_Subtract_IV8sS8s_IV8s(sbyte* x, sbyte y, System.UIntPtr length);

		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepCore_Subtract_IV16sS16s_IV16s")]
		private static unsafe extern Status yepCore_Subtract_IV16sS16s_IV16s(short* x, short y, System.UIntPtr length);

		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepCore_Subtract_IV32sS32s_IV32s")]
		private static unsafe extern Status yepCore_Subtract_IV32sS32s_IV32s(int* x, int y, System.UIntPtr length);

		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepCore_Subtract_IV64sS64s_IV64s")]
		private static unsafe extern Status yepCore_Subtract_IV64sS64s_IV64s(long* x, long y, System.UIntPtr length);

		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepCore_Subtract_IV32fS32f_IV32f")]
		private static unsafe extern Status yepCore_Subtract_IV32fS32f_IV32f(float* x, float y, System.UIntPtr length);

		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepCore_Subtract_IV64fS64f_IV64f")]
		private static unsafe extern Status yepCore_Subtract_IV64fS64f_IV64f(double* x, double y, System.UIntPtr length);

		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepCore_Subtract_S8sIV8s_IV8s")]
		private static unsafe extern Status yepCore_Subtract_S8sIV8s_IV8s(sbyte x, sbyte* y, System.UIntPtr length);

		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepCore_Subtract_S16sIV16s_IV16s")]
		private static unsafe extern Status yepCore_Subtract_S16sIV16s_IV16s(short x, short* y, System.UIntPtr length);

		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepCore_Subtract_S32sIV32s_IV32s")]
		private static unsafe extern Status yepCore_Subtract_S32sIV32s_IV32s(int x, int* y, System.UIntPtr length);

		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepCore_Subtract_S64sIV64s_IV64s")]
		private static unsafe extern Status yepCore_Subtract_S64sIV64s_IV64s(long x, long* y, System.UIntPtr length);

		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepCore_Subtract_S32fIV32f_IV32f")]
		private static unsafe extern Status yepCore_Subtract_S32fIV32f_IV32f(float x, float* y, System.UIntPtr length);

		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepCore_Subtract_S64fIV64f_IV64f")]
		private static unsafe extern Status yepCore_Subtract_S64fIV64f_IV64f(double x, double* y, System.UIntPtr length);

	}

}
