using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.common{
	
	
	
	
	
	public class ZoomImageRequest {
		
		///<summary>
		/// 唯品会图片URL，支持带域名或不带域名
		///</summary>
		
		private string image_url_;
		
		///<summary>
		/// 图片缩放宽度，0或者缺省则以height为缩放参考（width和height至少必填其中一个）
		///</summary>
		
		private int? width_;
		
		///<summary>
		/// 图片缩放高度，0或者缺省则以width为缩放参考（width和height至少必填其中一个）
		///</summary>
		
		private int? height_;
		
		public string GetImage_url(){
			return this.image_url_;
		}
		
		public void SetImage_url(string value){
			this.image_url_ = value;
		}
		public int? GetWidth(){
			return this.width_;
		}
		
		public void SetWidth(int? value){
			this.width_ = value;
		}
		public int? GetHeight(){
			return this.height_;
		}
		
		public void SetHeight(int? value){
			this.height_ = value;
		}
		
	}
	
}