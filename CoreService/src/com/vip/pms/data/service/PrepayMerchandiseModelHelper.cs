using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.pms.data.service{
	
	
	
	public class PrepayMerchandiseModelHelper : TBeanSerializer<PrepayMerchandiseModel>
	{
		
		public static PrepayMerchandiseModelHelper OBJ = new PrepayMerchandiseModelHelper();
		
		public static PrepayMerchandiseModelHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(PrepayMerchandiseModel structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("merchandiseId".Equals(schemeField.Trim())){
						
						needSkip = false;
						long value;
						value = iprot.ReadI64(); 
						
						structs.SetMerchandiseId(value);
					}
					
					
					
					
					
					if ("brandId".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetBrandId(value);
					}
					
					
					
					
					
					if ("prepayType".Equals(schemeField.Trim())){
						
						needSkip = false;
						short? value;
						value = iprot.ReadI16(); 
						
						structs.SetPrepayType(value);
					}
					
					
					
					
					
					if ("prepayAmount".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetPrepayAmount(value);
					}
					
					
					
					
					
					if ("listTips".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetListTips(value);
					}
					
					
					
					
					
					if ("detailTips".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetDetailTips(value);
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
		
		
		public void Write(PrepayMerchandiseModel structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetMerchandiseId() != null) {
				
				oprot.WriteFieldBegin("merchandiseId");
				oprot.WriteI64((long)structs.GetMerchandiseId()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("merchandiseId can not be null!");
			}
			
			
			if(structs.GetBrandId() != null) {
				
				oprot.WriteFieldBegin("brandId");
				oprot.WriteI64((long)structs.GetBrandId()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPrepayType() != null) {
				
				oprot.WriteFieldBegin("prepayType");
				oprot.WriteI16((short)structs.GetPrepayType()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPrepayAmount() != null) {
				
				oprot.WriteFieldBegin("prepayAmount");
				oprot.WriteI32((int)structs.GetPrepayAmount()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetListTips() != null) {
				
				oprot.WriteFieldBegin("listTips");
				oprot.WriteString(structs.GetListTips());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetDetailTips() != null) {
				
				oprot.WriteFieldBegin("detailTips");
				oprot.WriteString(structs.GetDetailTips());
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(PrepayMerchandiseModel bean){
			
			
		}
		
	}
	
}