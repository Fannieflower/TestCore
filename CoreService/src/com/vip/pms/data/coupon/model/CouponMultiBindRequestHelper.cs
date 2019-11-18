using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.pms.data.coupon.model{
	
	
	
	public class CouponMultiBindRequestHelper : TBeanSerializer<CouponMultiBindRequest>
	{
		
		public static CouponMultiBindRequestHelper OBJ = new CouponMultiBindRequestHelper();
		
		public static CouponMultiBindRequestHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(CouponMultiBindRequest structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("groupNo".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetGroupNo(value);
					}
					
					
					
					
					
					if ("userIds".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<long?> value;
						
						value = new List<long?>();
						iprot.ReadListBegin();
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
						
						iprot.ReadListEnd();
						
						structs.SetUserIds(value);
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
		
		
		public void Write(CouponMultiBindRequest structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetGroupNo() != null) {
				
				oprot.WriteFieldBegin("groupNo");
				oprot.WriteString(structs.GetGroupNo());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("groupNo can not be null!");
			}
			
			
			if(structs.GetUserIds() != null) {
				
				oprot.WriteFieldBegin("userIds");
				
				oprot.WriteListBegin();
				foreach(long _item0 in structs.GetUserIds()){
					
					oprot.WriteI64((long)_item0); 
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("userIds can not be null!");
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(CouponMultiBindRequest bean){
			
			
		}
		
	}
	
}