using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.xstore.user.face.service{
	
	
	
	
	
	public class XstoreBoxStateLogModel {
		
		///<summary>
		/// 自增长主键ID
		///</summary>
		
		private long? id_;
		
		///<summary>
		/// 盒子mac地址
		///</summary>
		
		private string boxMacAddr_;
		
		///<summary>
		/// 盒子温度
		///</summary>
		
		private string boxTemperature_;
		
		///<summary>
		/// 盒子和外网延时
		///</summary>
		
		private string boxPing_;
		
		///<summary>
		/// 盒子程序版本号
		///</summary>
		
		private string boxSoftwareVersion_;
		
		///<summary>
		/// 门店摄像头编码
		///</summary>
		
		private string cameraCode_;
		
		///<summary>
		/// 摄像头工作状态状态码
		///</summary>
		
		private string cameraStateCode_;
		
		///<summary>
		/// 设备和摄像头延时
		///</summary>
		
		private string cameraPing_;
		
		///<summary>
		/// 摄像头工作状态信息描述
		///</summary>
		
		private string cameraStateMsg_;
		
		///<summary>
		/// 摄像头视频流格式
		///</summary>
		
		private string cameraFormat_;
		
		///<summary>
		/// 摄像头fps
		///</summary>
		
		private string cameraFps_;
		
		///<summary>
		/// 摄像头分辨率
		///</summary>
		
		private string cameraResolution_;
		
		///<summary>
		/// 摄像头日志记录时间
		///</summary>
		
		private System.DateTime? stateLogTime_;
		
		///<summary>
		/// 创建时间
		///</summary>
		
		private System.DateTime? createTime_;
		
		///<summary>
		/// 更新时间
		///</summary>
		
		private System.DateTime? updateTime_;
		
		///<summary>
		/// 是否删除 0-未删除 1-删除，默认0
		///</summary>
		
		private int? deleteFlag_;
		
		///<summary>
		/// 门店编码
		///</summary>
		
		private string storeCode_;
		
		///<summary>
		/// POS机编码
		///</summary>
		
		private string posCode_;
		
		public long? GetId(){
			return this.id_;
		}
		
		public void SetId(long? value){
			this.id_ = value;
		}
		public string GetBoxMacAddr(){
			return this.boxMacAddr_;
		}
		
		public void SetBoxMacAddr(string value){
			this.boxMacAddr_ = value;
		}
		public string GetBoxTemperature(){
			return this.boxTemperature_;
		}
		
		public void SetBoxTemperature(string value){
			this.boxTemperature_ = value;
		}
		public string GetBoxPing(){
			return this.boxPing_;
		}
		
		public void SetBoxPing(string value){
			this.boxPing_ = value;
		}
		public string GetBoxSoftwareVersion(){
			return this.boxSoftwareVersion_;
		}
		
		public void SetBoxSoftwareVersion(string value){
			this.boxSoftwareVersion_ = value;
		}
		public string GetCameraCode(){
			return this.cameraCode_;
		}
		
		public void SetCameraCode(string value){
			this.cameraCode_ = value;
		}
		public string GetCameraStateCode(){
			return this.cameraStateCode_;
		}
		
		public void SetCameraStateCode(string value){
			this.cameraStateCode_ = value;
		}
		public string GetCameraPing(){
			return this.cameraPing_;
		}
		
		public void SetCameraPing(string value){
			this.cameraPing_ = value;
		}
		public string GetCameraStateMsg(){
			return this.cameraStateMsg_;
		}
		
		public void SetCameraStateMsg(string value){
			this.cameraStateMsg_ = value;
		}
		public string GetCameraFormat(){
			return this.cameraFormat_;
		}
		
		public void SetCameraFormat(string value){
			this.cameraFormat_ = value;
		}
		public string GetCameraFps(){
			return this.cameraFps_;
		}
		
		public void SetCameraFps(string value){
			this.cameraFps_ = value;
		}
		public string GetCameraResolution(){
			return this.cameraResolution_;
		}
		
		public void SetCameraResolution(string value){
			this.cameraResolution_ = value;
		}
		public System.DateTime? GetStateLogTime(){
			return this.stateLogTime_;
		}
		
		public void SetStateLogTime(System.DateTime? value){
			this.stateLogTime_ = value;
		}
		public System.DateTime? GetCreateTime(){
			return this.createTime_;
		}
		
		public void SetCreateTime(System.DateTime? value){
			this.createTime_ = value;
		}
		public System.DateTime? GetUpdateTime(){
			return this.updateTime_;
		}
		
		public void SetUpdateTime(System.DateTime? value){
			this.updateTime_ = value;
		}
		public int? GetDeleteFlag(){
			return this.deleteFlag_;
		}
		
		public void SetDeleteFlag(int? value){
			this.deleteFlag_ = value;
		}
		public string GetStoreCode(){
			return this.storeCode_;
		}
		
		public void SetStoreCode(string value){
			this.storeCode_ = value;
		}
		public string GetPosCode(){
			return this.posCode_;
		}
		
		public void SetPosCode(string value){
			this.posCode_ = value;
		}
		
	}
	
}