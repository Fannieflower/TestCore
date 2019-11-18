using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.xstore.user.face.service.photorecord{
	
	
	
	
	
	public class XstorePhotoRecordRequest {
		
		///<summary>
		/// 请求序列号,调用方需保证每个不同请求是唯一的
		///</summary>
		
		private string seqNo_;
		
		///<summary>
		/// 摄像头编码
		///</summary>
		
		private string cameraCode_;
		
		///<summary>
		/// 人脸原图数据
		///</summary>
		
		private com.vip.xstore.user.face.service.photorecord.XstorePhotoInputData originPhoto_;
		
		///<summary>
		/// 抠图文件数据
		///</summary>
		
		private List<com.vip.xstore.user.face.service.photorecord.XstorePhotoInputData> cutPhotos_;
		
		///<summary>
		/// 人脸抠图时间（毫秒）
		///</summary>
		
		private long? cutPhotoTime_;
		
		///<summary>
		/// 人脸原图拍摄时间（毫秒）
		///</summary>
		
		private long? originPhotoTime_;
		
		///<summary>
		/// 图片上传时间（毫秒）
		///</summary>
		
		private long? sendTime_;
		
		///<summary>
		/// 图片补上传标识，0-否 1-是
		///</summary>
		
		private int? resendFlag_;
		
		public string GetSeqNo(){
			return this.seqNo_;
		}
		
		public void SetSeqNo(string value){
			this.seqNo_ = value;
		}
		public string GetCameraCode(){
			return this.cameraCode_;
		}
		
		public void SetCameraCode(string value){
			this.cameraCode_ = value;
		}
		public com.vip.xstore.user.face.service.photorecord.XstorePhotoInputData GetOriginPhoto(){
			return this.originPhoto_;
		}
		
		public void SetOriginPhoto(com.vip.xstore.user.face.service.photorecord.XstorePhotoInputData value){
			this.originPhoto_ = value;
		}
		public List<com.vip.xstore.user.face.service.photorecord.XstorePhotoInputData> GetCutPhotos(){
			return this.cutPhotos_;
		}
		
		public void SetCutPhotos(List<com.vip.xstore.user.face.service.photorecord.XstorePhotoInputData> value){
			this.cutPhotos_ = value;
		}
		public long? GetCutPhotoTime(){
			return this.cutPhotoTime_;
		}
		
		public void SetCutPhotoTime(long? value){
			this.cutPhotoTime_ = value;
		}
		public long? GetOriginPhotoTime(){
			return this.originPhotoTime_;
		}
		
		public void SetOriginPhotoTime(long? value){
			this.originPhotoTime_ = value;
		}
		public long? GetSendTime(){
			return this.sendTime_;
		}
		
		public void SetSendTime(long? value){
			this.sendTime_ = value;
		}
		public int? GetResendFlag(){
			return this.resendFlag_;
		}
		
		public void SetResendFlag(int? value){
			this.resendFlag_ = value;
		}
		
	}
	
}