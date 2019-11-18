using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.pms.data.service{
	
	
	
	public class ConfirmationResultHelper : TBeanSerializer<ConfirmationResult>
	{
		
		public static ConfirmationResultHelper OBJ = new ConfirmationResultHelper();
		
		public static ConfirmationResultHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(ConfirmationResult structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("type".Equals(schemeField.Trim())){
						
						needSkip = false;
						byte value;
						value = iprot.ReadByte(); 
						
						structs.SetType(value);
					}
					
					
					
					
					
					if ("no".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetNo(value);
					}
					
					
					
					
					
					if ("scheduleId".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetScheduleId(value);
					}
					
					
					
					
					
					if ("supplierNo".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetSupplierNo(value);
					}
					
					
					
					
					
					if ("brandId".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetBrandId(value);
					}
					
					
					
					
					
					if ("info".Equals(schemeField.Trim())){
						
						needSkip = false;
						com.vip.pms.data.service.ConfirmationInfo value;
						
						value = new com.vip.pms.data.service.ConfirmationInfo();
						com.vip.pms.data.service.ConfirmationInfoHelper.getInstance().Read(value, iprot);
						
						structs.SetInfo(value);
					}
					
					
					
					
					
					if ("merchandiseNo".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetMerchandiseNo(value);
					}
					
					
					
					
					
					if ("actBeginTime".Equals(schemeField.Trim())){
						
						needSkip = false;
						System.DateTime? value;
						value = Osp.Sdk.Util.TimeUtil.FromUnixTime(iprot.ReadI64()); 
						
						structs.SetActBeginTime(value);
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
		
		
		public void Write(ConfirmationResult structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetType() != null) {
				
				oprot.WriteFieldBegin("type");
				oprot.WriteByte((byte)structs.GetType()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("type can not be null!");
			}
			
			
			if(structs.GetNo() != null) {
				
				oprot.WriteFieldBegin("no");
				oprot.WriteString(structs.GetNo());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("no can not be null!");
			}
			
			
			if(structs.GetScheduleId() != null) {
				
				oprot.WriteFieldBegin("scheduleId");
				oprot.WriteString(structs.GetScheduleId());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("scheduleId can not be null!");
			}
			
			
			if(structs.GetSupplierNo() != null) {
				
				oprot.WriteFieldBegin("supplierNo");
				oprot.WriteString(structs.GetSupplierNo());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("supplierNo can not be null!");
			}
			
			
			if(structs.GetBrandId() != null) {
				
				oprot.WriteFieldBegin("brandId");
				oprot.WriteString(structs.GetBrandId());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetInfo() != null) {
				
				oprot.WriteFieldBegin("info");
				
				com.vip.pms.data.service.ConfirmationInfoHelper.getInstance().Write(structs.GetInfo(), oprot);
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetMerchandiseNo() != null) {
				
				oprot.WriteFieldBegin("merchandiseNo");
				oprot.WriteI64((long)structs.GetMerchandiseNo()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetActBeginTime() != null) {
				
				oprot.WriteFieldBegin("actBeginTime");
				oprot.WriteI64(Osp.Sdk.Util.TimeUtil.ToUnixTime((System.DateTime)structs.GetActBeginTime())); 
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(ConfirmationResult bean){
			
			
		}
		
	}
	
}