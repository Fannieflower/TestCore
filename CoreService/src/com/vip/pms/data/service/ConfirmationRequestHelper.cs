using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.pms.data.service{
	
	
	
	public class ConfirmationRequestHelper : TBeanSerializer<ConfirmationRequest>
	{
		
		public static ConfirmationRequestHelper OBJ = new ConfirmationRequestHelper();
		
		public static ConfirmationRequestHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(ConfirmationRequest structs, Protocol iprot){
			
			
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
					
					
					
					
					
					if ("merchandiseNos".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<long?> value;
						
						value = new List<long?>();
						iprot.ReadSetBegin();
						while(true){
							
							try{
								
								long elem1;
								elem1 = iprot.ReadI64(); 
								
								value.Add(elem1);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadSetEnd();
						
						structs.SetMerchandiseNos(value);
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
		
		
		public void Write(ConfirmationRequest structs, Protocol oprot){
			
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
			
			
			if(structs.GetMerchandiseNos() != null) {
				
				oprot.WriteFieldBegin("merchandiseNos");
				
				oprot.WriteSetBegin();
				foreach(long _item0 in structs.GetMerchandiseNos()){
					
					oprot.WriteI64((long)_item0); 
					
				}
				
				oprot.WriteSetEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(ConfirmationRequest bean){
			
			
		}
		
	}
	
}