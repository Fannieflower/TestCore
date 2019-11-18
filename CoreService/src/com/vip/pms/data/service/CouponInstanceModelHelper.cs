using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.pms.data.service{
	
	
	
	public class CouponInstanceModelHelper : TBeanSerializer<CouponInstanceModel>
	{
		
		public static CouponInstanceModelHelper OBJ = new CouponInstanceModelHelper();
		
		public static CouponInstanceModelHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(CouponInstanceModel structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("id".Equals(schemeField.Trim())){
						
						needSkip = false;
						long value;
						value = iprot.ReadI64(); 
						
						structs.SetId(value);
					}
					
					
					
					
					
					if ("couponNo".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCouponNo(value);
					}
					
					
					
					
					
					if ("couponSn".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCouponSn(value);
					}
					
					
					
					
					
					if ("userId".Equals(schemeField.Trim())){
						
						needSkip = false;
						long value;
						value = iprot.ReadI64(); 
						
						structs.SetUserId(value);
					}
					
					
					
					
					
					if ("groupType".Equals(schemeField.Trim())){
						
						needSkip = false;
						byte value;
						value = iprot.ReadByte(); 
						
						structs.SetGroupType(value);
					}
					
					
					
					
					
					if ("activateTime".Equals(schemeField.Trim())){
						
						needSkip = false;
						long value;
						value = iprot.ReadI64(); 
						
						structs.SetActivateTime(value);
					}
					
					
					
					
					
					if ("useTime".Equals(schemeField.Trim())){
						
						needSkip = false;
						long value;
						value = iprot.ReadI64(); 
						
						structs.SetUseTime(value);
					}
					
					
					
					
					
					if ("beginTime".Equals(schemeField.Trim())){
						
						needSkip = false;
						long value;
						value = iprot.ReadI64(); 
						
						structs.SetBeginTime(value);
					}
					
					
					
					
					
					if ("endTime".Equals(schemeField.Trim())){
						
						needSkip = false;
						long value;
						value = iprot.ReadI64(); 
						
						structs.SetEndTime(value);
					}
					
					
					
					
					
					if ("bindOrderSn".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetBindOrderSn(value);
					}
					
					
					
					
					
					if ("useLimit".Equals(schemeField.Trim())){
						
						needSkip = false;
						double value;
						value = iprot.ReadDouble();
						
						structs.SetUseLimit(value);
					}
					
					
					
					
					
					if ("favAmount".Equals(schemeField.Trim())){
						
						needSkip = false;
						double value;
						value = iprot.ReadDouble();
						
						structs.SetFavAmount(value);
					}
					
					
					
					
					
					if ("platform".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetPlatform(value);
					}
					
					
					
					
					
					if ("status".Equals(schemeField.Trim())){
						
						needSkip = false;
						byte value;
						value = iprot.ReadByte(); 
						
						structs.SetStatus(value);
					}
					
					
					
					
					
					if ("isDeleted".Equals(schemeField.Trim())){
						
						needSkip = false;
						byte value;
						value = iprot.ReadByte(); 
						
						structs.SetIsDeleted(value);
					}
					
					
					
					
					
					if ("createTime".Equals(schemeField.Trim())){
						
						needSkip = false;
						long value;
						value = iprot.ReadI64(); 
						
						structs.SetCreateTime(value);
					}
					
					
					
					
					
					if ("updateTime".Equals(schemeField.Trim())){
						
						needSkip = false;
						long value;
						value = iprot.ReadI64(); 
						
						structs.SetUpdateTime(value);
					}
					
					
					
					
					if(needSkip){
						
						ProtocolUtil.skip(iprot);
					}
					
					iprot.ReadFieldEnd();
				}
				
				iprot.ReadStructEnd();
				Validate(structs);
			}
			else{
				
				throw new OspException();
			}
			
			
		}
		
		
		public void Write(CouponInstanceModel structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetId() != null) {
				
				oprot.WriteFieldBegin("id");
				oprot.WriteI64((long)structs.GetId()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("id can not be null!");
			}
			
			
			if(structs.GetCouponNo() != null) {
				
				oprot.WriteFieldBegin("couponNo");
				oprot.WriteString(structs.GetCouponNo());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("couponNo can not be null!");
			}
			
			
			if(structs.GetCouponSn() != null) {
				
				oprot.WriteFieldBegin("couponSn");
				oprot.WriteString(structs.GetCouponSn());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("couponSn can not be null!");
			}
			
			
			if(structs.GetUserId() != null) {
				
				oprot.WriteFieldBegin("userId");
				oprot.WriteI64((long)structs.GetUserId()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("userId can not be null!");
			}
			
			
			if(structs.GetGroupType() != null) {
				
				oprot.WriteFieldBegin("groupType");
				oprot.WriteByte((byte)structs.GetGroupType()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("groupType can not be null!");
			}
			
			
			if(structs.GetActivateTime() != null) {
				
				oprot.WriteFieldBegin("activateTime");
				oprot.WriteI64((long)structs.GetActivateTime()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("activateTime can not be null!");
			}
			
			
			if(structs.GetUseTime() != null) {
				
				oprot.WriteFieldBegin("useTime");
				oprot.WriteI64((long)structs.GetUseTime()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("useTime can not be null!");
			}
			
			
			if(structs.GetBeginTime() != null) {
				
				oprot.WriteFieldBegin("beginTime");
				oprot.WriteI64((long)structs.GetBeginTime()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("beginTime can not be null!");
			}
			
			
			if(structs.GetEndTime() != null) {
				
				oprot.WriteFieldBegin("endTime");
				oprot.WriteI64((long)structs.GetEndTime()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("endTime can not be null!");
			}
			
			
			if(structs.GetBindOrderSn() != null) {
				
				oprot.WriteFieldBegin("bindOrderSn");
				oprot.WriteString(structs.GetBindOrderSn());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("bindOrderSn can not be null!");
			}
			
			
			if(structs.GetUseLimit() != null) {
				
				oprot.WriteFieldBegin("useLimit");
				oprot.WriteDouble((double)structs.GetUseLimit());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("useLimit can not be null!");
			}
			
			
			if(structs.GetFavAmount() != null) {
				
				oprot.WriteFieldBegin("favAmount");
				oprot.WriteDouble((double)structs.GetFavAmount());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("favAmount can not be null!");
			}
			
			
			if(structs.GetPlatform() != null) {
				
				oprot.WriteFieldBegin("platform");
				oprot.WriteString(structs.GetPlatform());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("platform can not be null!");
			}
			
			
			if(structs.GetStatus() != null) {
				
				oprot.WriteFieldBegin("status");
				oprot.WriteByte((byte)structs.GetStatus()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("status can not be null!");
			}
			
			
			if(structs.GetIsDeleted() != null) {
				
				oprot.WriteFieldBegin("isDeleted");
				oprot.WriteByte((byte)structs.GetIsDeleted()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("isDeleted can not be null!");
			}
			
			
			if(structs.GetCreateTime() != null) {
				
				oprot.WriteFieldBegin("createTime");
				oprot.WriteI64((long)structs.GetCreateTime()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("createTime can not be null!");
			}
			
			
			if(structs.GetUpdateTime() != null) {
				
				oprot.WriteFieldBegin("updateTime");
				oprot.WriteI64((long)structs.GetUpdateTime()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("updateTime can not be null!");
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(CouponInstanceModel bean){
			
			
		}
		
	}
	
}